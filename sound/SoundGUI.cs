/* Copyright (C) 2008 Jeff Morton (jeffrey.raymond.morton@gmail.com)
 
   This program is free software; you can redistribute it and/or modify
   it under the terms of the GNU General Public License as published by
   the Free Software Foundation; either version 2 of the License, or
   (at your option) any later version.

   This program is distributed in the hope that it will be useful,
   but WITHOUT ANY WARRANTY; without even the implied warranty of
   MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
   GNU General Public License for more details.
 
   You should have received a copy of the GNU General Public License
   along with this program; if not, write to the Free Software
   Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307  USA */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using neuralNetwork;
using System.Threading;
using robot;

namespace SoundCatcher
{
    /*
     *  This class is part of the program used for receiving sound input for speech. 
     *  This class deals with the user interface
     *  This class has been modified to add the functionalities required by the project e.g. recording samples etc.  
     * 
     */
    
    public partial class SoundGUI : Form
    {
        // declaration of variables
        private WaveInRecorder _recorder;
        private byte[] _recorderBuffer;
        private WaveOutPlayer _player;
        private byte[] _playerBuffer;
        private WaveFormat _waveFormat;
        private static AudioFrame _audioFrame;
        private FifoStream _streamOut;
        private MemoryStream _streamMemory;
        private Stream _streamWave;
        private FileStream _streamFile;
        private bool _isPlayer = false;  // audio output for testing
        private bool _isTest = false;  // signal generation for testing
        private bool _isSaving = false;
        private bool _isShown = true;
        private string _sampleFilename;
        private DateTime _timeLastDetection;

        private bool takeSample = false;
        private bool isRecordingSample = false;
        private int takeSampleWaitTime = 2;
        private DateTime sampleInitialTime;

        private bool recordInteraction = false;
        private bool isRecordingInteraction = false;
        private int recordInteractionWaitTime = 1;
        private DateTime interactionInitialTime;

        private Thread workerThread = null;

        private NeuralNetwork neuralNetwork = new NeuralNetwork();

        private Robot robot;

        public SoundGUI()
        {
            InitializeComponent();
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            if (WaveNative.waveInGetNumDevs() == 0)
            {
                textBoxConsole.AppendText(DateTime.Now.ToString() + " : No audio input devices detected\r\n");
            }
            else
            {
                textBoxConsole.AppendText(DateTime.Now.ToString() + " : Audio input device detected\r\n");
                if (_isPlayer == true)
                    _streamOut = new FifoStream();
                _audioFrame = new AudioFrame(_isTest);
                _audioFrame.IsDetectingEvents = Properties.Settings.Default.SettingIsDetectingEvents;
                _audioFrame.AmplitudeThreshold = Properties.Settings.Default.SettingAmplitudeThreshold;
                _streamMemory = new MemoryStream();

                neuralNetwork.setOutputErrorComponent(networkErrorLabel);
                neuralNetwork.learn();
                double error = neuralNetwork.getError();
                while(error>0.0004)
                {
                    neuralNetwork.reduceError();
                    error = neuralNetwork.getError();
                }
                _audioFrame.setNeuralNetwork(neuralNetwork);
                _audioFrame.setRobot(robot);

                Start();
            }
        }
        private void FormMain_Resize(object sender, EventArgs e)
        {
            if (_audioFrame != null)
            {
                _audioFrame.RenderTimeDomainLeft(ref pictureBoxTimeDomainLeft);
                _audioFrame.RenderTimeDomainRight(ref pictureBoxTimeDomainRight);
               
               
          
            
            }
        }
        private void FormMain_SizeChanged(object sender, EventArgs e)
        {
            if (_isShown & this.WindowState == FormWindowState.Minimized)
            {
                foreach (Form f in this.MdiChildren)
                {
                    f.WindowState = FormWindowState.Normal;
                }
                this.ShowInTaskbar = false;
                this.Visible = false;
                notifyIcon1.Visible = true;
                _isShown = false;
            }
        }
        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Stop();
            if (_isSaving == true)
            {
                byte[] waveBuffer = new byte[Properties.Settings.Default.SettingBitsPerSample];
                _streamWave = WaveStream.CreateStream(_streamMemory, _waveFormat);
                waveBuffer = new byte[_streamWave.Length - _streamWave.Position];
                _streamWave.Read(waveBuffer, 0, waveBuffer.Length);
                if (Properties.Settings.Default.SettingOutputPath != "")
                    _streamFile = new FileStream(Properties.Settings.Default.SettingOutputPath + "\\" + _sampleFilename, FileMode.Create);
                else
                    _streamFile = new FileStream(_sampleFilename, FileMode.Create);
                _streamFile.Write(waveBuffer, 0, waveBuffer.Length);
                _isSaving = false;
            }
            if (_streamOut != null)
                try
                {
                    _streamOut.Close();
                }
                finally
                {
                    _streamOut = null;
                }
            if (_streamWave != null)
                try
                {
                    _streamWave.Close();
                }
                finally
                {
                    _streamWave = null;
                }
            if (_streamFile != null)
                try
                {
                    _streamFile.Close();
                }
                finally
                {
                    _streamFile = null;
                }
            if (_streamMemory != null)
                try
                {
                    _streamMemory.Close();
                }
                finally
                {
                    _streamMemory = null;
                }
        }
        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            notifyIcon1.Visible = false;
            this.Visible = true;
            this.ShowInTaskbar = true;
            this.WindowState = FormWindowState.Normal;
            _isShown = true;
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAboutDialog form = new FormAboutDialog();
            form.Show();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormOptionsDialog form = new FormOptionsDialog();
            if (form.ShowDialog() == DialogResult.OK)
            {
                _audioFrame.IsDetectingEvents = form.IsDetectingEvents;
                _audioFrame.AmplitudeThreshold = form.AmplitudeThreshold;
            }
        }
        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSettingsDialog form = new FormSettingsDialog();
            if (form.ShowDialog() == DialogResult.OK)
            {
                Stop();
                if (_isSaving == true)
                {
                    byte[] waveBuffer = new byte[Properties.Settings.Default.SettingBitsPerSample];
                    _streamWave = WaveStream.CreateStream(_streamMemory, _waveFormat);
                    waveBuffer = new byte[_streamWave.Length - _streamWave.Position];
                    _streamWave.Read(waveBuffer, 0, waveBuffer.Length);
                    _streamFile = new FileStream(_sampleFilename, FileMode.Create);
                    _streamFile.Write(waveBuffer, 0, waveBuffer.Length);
                    _isSaving = false;
                }
                if (_streamOut != null)
                    try
                    {
                        _streamOut.Close();
                    }
                    finally
                    {
                        _streamOut = null;
                    }
                if (_streamWave != null)
                    try
                    {
                        _streamWave.Close();
                    }
                    finally
                    {
                        _streamWave = null;
                    }
                if (_streamFile != null)
                    try
                    {
                        _streamFile.Close();
                    }
                    finally
                    {
                        _streamFile = null;
                    }
                if (_streamMemory != null)
                    try
                    {
                        _streamMemory.Close();
                    }
                    finally
                    {
                        _streamMemory = null;
                    }
                if (_isPlayer == true)
                    _streamOut = new FifoStream();
                _audioFrame = new AudioFrame(_isTest);
                _audioFrame.IsDetectingEvents = Properties.Settings.Default.SettingIsDetectingEvents;
                _audioFrame.AmplitudeThreshold = Properties.Settings.Default.SettingAmplitudeThreshold;
                _streamMemory = new MemoryStream();
                Start();
            }
        }
        private void Start()
        {
            Stop();
            try
            {
                _waveFormat = new WaveFormat(Properties.Settings.Default.SettingSamplesPerSecond, Properties.Settings.Default.SettingBitsPerSample, Properties.Settings.Default.SettingChannels);
                _recorder = new WaveInRecorder(Properties.Settings.Default.SettingAudioInputDevice, _waveFormat, Properties.Settings.Default.SettingBytesPerFrame * Properties.Settings.Default.SettingChannels, 3, new BufferDoneEventHandler(DataArrived));
                if (_isPlayer == true)
                    _player = new WaveOutPlayer(Properties.Settings.Default.SettingAudioOutputDevice, _waveFormat, Properties.Settings.Default.SettingBytesPerFrame * Properties.Settings.Default.SettingChannels, 3, new BufferFillEventHandler(Filler));
                textBoxConsole.AppendText(DateTime.Now.ToString() + " : Audio input device polling started\r\n");
                textBoxConsole.AppendText(DateTime.Now + " : Device = " + Properties.Settings.Default.SettingAudioInputDevice.ToString() + "\r\n");
                textBoxConsole.AppendText(DateTime.Now + " : Channels = " + Properties.Settings.Default.SettingChannels.ToString() + "\r\n");
                textBoxConsole.AppendText(DateTime.Now + " : Bits per sample = " + Properties.Settings.Default.SettingBitsPerSample.ToString() + "\r\n");
                textBoxConsole.AppendText(DateTime.Now + " : Samples per second = " + Properties.Settings.Default.SettingSamplesPerSecond.ToString() + "\r\n");
                textBoxConsole.AppendText(DateTime.Now + " : Frame size = " + Properties.Settings.Default.SettingBytesPerFrame.ToString() + "\r\n");
                _audioFrame.sampleMessageTextLabel = sampleMessageTextLabel;
                _audioFrame.interactLabel = interactLabel;
                _audioFrame.neuralOutputLabel = neuralOutputlabel;

                AudioFrame.sampleNameTextBox = sampleNameTextBox;

            }
            catch (Exception ex)
            {
                textBoxConsole.AppendText(DateTime.Now + " : " + ex.InnerException.ToString() + "\r\n");
            }
        }
        private void Stop()
        {
            if (_recorder != null)
                try
                {
                    _recorder.Dispose();
                }
                finally
                {
                    _recorder = null;
                }
            if (_isPlayer == true)
            {
                if (_player != null)
                    try
                    {
                        _player.Dispose();
                    }
                    finally
                    {
                        _player = null;
                    }
                _streamOut.Flush(); // clear all pending data
            }
            textBoxConsole.AppendText(DateTime.Now.ToString() + " : Audio input device polling stopped\r\n");
        }
        private void Filler(IntPtr data, int size)
        {
            if (_isPlayer == true)
            {
                if (_playerBuffer == null || _playerBuffer.Length < size)
                    _playerBuffer = new byte[size];
                if (_streamOut.Length >= size)
                    _streamOut.Read(_playerBuffer, 0, size);
                else
                    for (int i = 0; i < _playerBuffer.Length; i++)
                        _playerBuffer[i] = 0;
                System.Runtime.InteropServices.Marshal.Copy(_playerBuffer, 0, data, size);
            }
        }
        private void DataArrived(IntPtr data, int size)
        {
                       
            if (_isSaving == true)
            {
                byte[] recBuffer = new byte[size];
                System.Runtime.InteropServices.Marshal.Copy(data, recBuffer, 0, size);
                _streamMemory.Write(recBuffer, 0, recBuffer.Length);
            }
            if (_recorderBuffer == null || _recorderBuffer.Length != size)
                _recorderBuffer = new byte[size];
            if (_recorderBuffer != null)
            {
                System.Runtime.InteropServices.Marshal.Copy(data, _recorderBuffer, 0, size);
                if (_isPlayer == true)
                    _streamOut.Write(_recorderBuffer, 0, _recorderBuffer.Length);
                _audioFrame.Process(ref _recorderBuffer);
                if (_audioFrame.IsEventActive == true)
                {
                    if (_isSaving == false && Properties.Settings.Default.SettingIsSaving == true)
                    {
                        _sampleFilename = DateTime.Now.ToString("yyyyMMddHHmmss") + ".wav";
                        _timeLastDetection = DateTime.Now;
                        _isSaving = true;
                    }
                    else
                    {
                        _timeLastDetection = DateTime.Now;
                    }
                    Invoke(new MethodInvoker(AmplitudeEvent));
                }
                if (_isSaving == true && DateTime.Now.Subtract(_timeLastDetection).Seconds > Properties.Settings.Default.SettingSecondsToSave)
                {
                    byte[] waveBuffer = new byte[Properties.Settings.Default.SettingBitsPerSample];
                    _streamWave = WaveStream.CreateStream(_streamMemory, _waveFormat);
                    waveBuffer = new byte[_streamWave.Length - _streamWave.Position];
                    _streamWave.Read(waveBuffer, 0, waveBuffer.Length);
                    if (Properties.Settings.Default.SettingOutputPath != "")
                        _streamFile = new FileStream(Properties.Settings.Default.SettingOutputPath + "\\" + _sampleFilename, FileMode.Create);
                    else
                        _streamFile = new FileStream(_sampleFilename, FileMode.Create);
                    _streamFile.Write(waveBuffer, 0, waveBuffer.Length);
                    if (_streamWave != null) { _streamWave.Close(); }
                    if (_streamFile != null) { _streamFile.Close(); }
                    _streamMemory = new MemoryStream();
                    _isSaving = false;
                    Invoke(new MethodInvoker(FileSavedEvent));
                }

               
                if (takeSample)
                {
                    DateTime currentTime = DateTime.Now;
                    int difference = (currentTime - sampleInitialTime).Seconds;
                    if (!isRecordingSample)
                    {
                        sampleMessageTextLabel.Text = takeSampleWaitTime - difference + " seconds till recording begins ";
                        if (difference >= takeSampleWaitTime)
                        {
                            isRecordingSample = true;
                            sampleMessageTextLabel.Text = "recording sample";
                            AudioFrame.setTakeSample(true);
                            resetSamplingControlVariables();

                        }
                    }
                }

                if(robot.getIsListening())
                {
                    interact();
                }

                if (_audioFrame.getUnrecognisedVoiceTone())
                {
                    unrecognisedVoiceToneRecieved();
                }

                if (recordInteraction)
                {
                    DateTime currentTime = DateTime.Now;
                    int difference = (currentTime - interactionInitialTime).Seconds;
                    if (!isRecordingInteraction)
                    {
                        interactLabel.Text = recordInteractionWaitTime - difference + " seconds till interaction begins ";
                        if (difference >= recordInteractionWaitTime)
                        {
                            isRecordingInteraction = true;
                            interactLabel.Text = "recording interaction";
                            AudioFrame.setRecordInteraction(true);
                            resetInteractionControlVariables();

                        }
                    }
                }
                _audioFrame.RenderTimeDomainLeft(ref pictureBoxTimeDomainLeft);
                _audioFrame.RenderTimeDomainRight(ref pictureBoxTimeDomainRight);
              
           
            }

        }

        private void resetSamplingControlVariables()
        {
            takeSample = false;
            isRecordingSample = false; 
        }

        private void resetInteractionControlVariables()
        {
            recordInteraction = false;
            isRecordingInteraction = false; 
        }
        private void AmplitudeEvent()
        {
            toolStripStatusLabel1.Text = "Last event: " + _timeLastDetection.ToString();
        }
        private void FileSavedEvent()
        {
            textBoxConsole.AppendText(_timeLastDetection.ToString() + " : File " + _sampleFilename + " saved\r\n");
        }

        private void textBoxConsole_TextChanged(object sender, EventArgs e)
        {

        }

        private void takeSampleButton_Click(object sender, EventArgs e)
        {
            takeSample = true;
            sampleInitialTime = DateTime.Now;

        }

        private void interact()
        {
            AudioFrame.playBeep();
            recordInteraction = true;
            interactionInitialTime = DateTime.Now;
            robot.setIsListening(false);
        }

        private void unrecognisedVoiceToneRecieved()
        {
            AudioFrame.playHonk();
            recordInteraction = true;
            interactionInitialTime = DateTime.Now;
            robot.setIsListening(false);
            _audioFrame.setUnrecognisedVoiceTone(false);
        }

        public void setRobot(Robot robotArg)
        {
            robot = robotArg;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void splitContainer5_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sampleMessageTextLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void interactButton_Click(object sender, EventArgs e)
        {
            AudioFrame.playBeep();
            recordInteraction = true;
            interactionInitialTime = DateTime.Now;
        }

        private void learnButton_Click(object sender, EventArgs e)
        {
            workerThread = new Thread(new ThreadStart(neuralNetwork.reduceError));
            workerThread.Start();
        }
    }
}