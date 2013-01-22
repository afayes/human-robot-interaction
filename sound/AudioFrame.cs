
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
using System.Collections;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.IO;
using System.Text;
using neuralNetwork;
using System.Media;
using robot;



namespace SoundCatcher
{
    /*
     *  This class is part of the program used for receiving sound input for speech. 
     *  This class does the sound processing
     *  This class has been modified to add the functionalities required by the project e.g. feature extraction, recording samples etc.  
     * 
     */


    class AudioFrame
    {
        // declaation of variables
        private double[] _waveLeft;
        private double[] _waveRight;
       
        private SignalGenerator _signalGenerator;
        private bool _isTest = false;
        public bool IsDetectingEvents = false;
        public bool IsEventActive = false;
        public int AmplitudeThreshold = 16384;
        
        private int counter = 0;
        private int sampleRecordDuration = 1; // seconds
        private static DateTime initialTime;
        private static FileStream output;

        //-----record interaction variables
        private int interactCounter = 0;
        private int interactRecordDuration = 1; // seconds
        private static DateTime interactInitialTime;
        //---------------------------------
        private double minPerSecond = 0;
        private double maxPerSecond = 0;

        private double minSumPerSecond = 0;
        private double maxSumPerSecond = 0;

        private double minAveragePerSecond= 0;
        private double maxAveragePerSecond= 0;
        
        //------------------------
        private double interactMinPerSecond = 0;
        private double interactMaxPerSecond = 0;

        private double interactMinSumPerSecond = 0;
        private double interactMaxSumPerSecond = 0;

        private double interactMinAveragePerSecond = 0;
        private double interactMaxAveragePerSecond = 0;
        //------------------------

        private static bool takeSample = false;
        private static bool recordInteraction = false; 

        public System.Windows.Forms.Label sampleMessageTextLabel;
        public static System.Windows.Forms.TextBox sampleNameTextBox;

        public System.Windows.Forms.Label interactLabel;

        private NeuralNetwork neuralNetwork ;

        public System.Windows.Forms.Label neuralOutputLabel;

        private static SoundPlayer myPlayer;

        private Robot robot;

        private bool unrecognisedVoiceTone = false;
   

        public AudioFrame()
        {
        }
        public AudioFrame(bool isTest)
        {
            _isTest = isTest;
        }

        /// <summary>
        /// Process 16 bit sample
        /// </summary>
        /// <param name="wave"></param>
        public void Process(ref byte[] wave)
        {
          
            _waveLeft = new double[wave.Length / 4];
            _waveRight = new double[wave.Length / 4];

            if (_isTest == false)
            {
                // Split out channels from sample
                int h = 0;
                for (int i = 0; i < wave.Length; i += 4)
                {
                    _waveLeft[h] = (double)BitConverter.ToInt16(wave, i);
                    if (IsDetectingEvents == true)
                        if (_waveLeft[h] > AmplitudeThreshold || _waveLeft[h] < -AmplitudeThreshold)
                            IsEventActive = true;
                    _waveRight[h] = (double)BitConverter.ToInt16(wave, i + 2);
                    if (IsDetectingEvents == true)
                        if (_waveLeft[h] > AmplitudeThreshold || _waveLeft[h] < -AmplitudeThreshold)
                            IsEventActive = true;
                    h++;
                }
            }
            else
            {
                // Generate artificial sample for testing
                _signalGenerator = new SignalGenerator();
                _signalGenerator.SetWaveform("Sine");
                _signalGenerator.SetSamplingRate(44100);
                _signalGenerator.SetSamples(8192);
                _signalGenerator.SetFrequency(4096);
                _signalGenerator.SetAmplitude(32768);
                _waveLeft = _signalGenerator.GenerateSignal();
                _waveRight = _signalGenerator.GenerateSignal();
            }


            if (takeSample)
            {
               

                DateTime currentTime = DateTime.Now;
                int difference = (currentTime - initialTime).Seconds;
                
                
                if (difference < sampleRecordDuration)
                {
                    try
                    {
                        double[] soundData = new double[_waveLeft.Length];
                        Array.Copy(_waveLeft, soundData, _waveLeft.Length);
                        Array.Sort(soundData);
                        double min = soundData[0];
                        double max = soundData[soundData.Length - 1];

                        if (min < minPerSecond)
                        {
                            minPerSecond = min;
                        }

                        if (max > maxPerSecond)
                        {
                            maxPerSecond = max;
                        }

                        minSumPerSecond += min;
                        maxSumPerSecond += max;

                       
                        string data = Environment.NewLine + counter + "). " + "min = " +min + " max = " + max;
                          
                        Byte[] text = new UTF8Encoding(true).GetBytes(data);
                        output.Write(text, 0, text.Length);
                        counter++;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                    }
                }

                else
                {
                    minAveragePerSecond = minSumPerSecond / counter;
                    maxAveragePerSecond = maxSumPerSecond / counter;

                    string data = Environment.NewLine + "min Per second = " + minPerSecond + Environment.NewLine + "max per second = " + maxPerSecond + Environment.NewLine + "min average = " + minAveragePerSecond + Environment.NewLine + "max average = " + maxAveragePerSecond;
                    
                    Byte[] text = new UTF8Encoding(true).GetBytes(data);
                    output.Write(text, 0, text.Length);

                    counter = 0;


                    output.Flush();
                    output.Close();
                    takeSample = false;
                    sampleMessageTextLabel.Text = "Finished recording";

                    // reset variables
                    minPerSecond = 0;
                    maxPerSecond = 0;

                    minSumPerSecond = 0;
                    maxSumPerSecond = 0;

                    minAveragePerSecond= 0;
                    maxAveragePerSecond= 0;
                }


            }

            //--------Record Interaction-------------
            if (recordInteraction)
            {
                DateTime interactCurrentTime = DateTime.Now;
                int difference = (interactCurrentTime - interactInitialTime).Seconds;              

                if (difference < interactRecordDuration)
                {
                    try
                    {
                        double[] soundData = new double[_waveLeft.Length];
                        Array.Copy(_waveLeft, soundData, _waveLeft.Length);
                        Array.Sort(soundData);
                        double min = soundData[0];
                        double max = soundData[soundData.Length - 1];

                        if (min < interactMinPerSecond)
                        {
                            interactMinPerSecond = min;
                        }

                        if (max > interactMaxPerSecond)
                        {
                            interactMaxPerSecond = max;
                        }

                        interactMinSumPerSecond += min;
                        interactMaxSumPerSecond += max;

                        
                      
                        interactCounter++;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                    }
                }

                else
                {
                    interactMinAveragePerSecond = interactMinSumPerSecond / interactCounter;
                    interactMaxAveragePerSecond = interactMaxSumPerSecond / interactCounter;

                    interactCounter = 0;
                    recordInteraction = false;
                    interactLabel.Text = "Interaction finished ";

                    double [] input = {interactMinPerSecond, interactMaxPerSecond, interactMinAveragePerSecond, interactMaxAveragePerSecond  };

                    String voiceTone = neuralNetwork.computeOutput(input);
                    neuralOutputLabel.Text = "Classification is: " + voiceTone;
                    Console.WriteLine("Min per second = " + interactMinPerSecond + " Max per second = " + interactMaxPerSecond + " Min average = " + interactMinAveragePerSecond + " Max average = " + interactMaxAveragePerSecond );

                    if (voiceTone != "Unrecognised")
                    {
                        robot.listen(voiceTone);
                    }

                    else
                    {
                        unrecognisedVoiceTone = true;
                    }

                    // reset variables
                    interactMinPerSecond = 0;
                    interactMaxPerSecond = 0;

                    interactMinSumPerSecond = 0;
                    interactMaxSumPerSecond = 0;

                    interactMinAveragePerSecond = 0;
                    interactMaxAveragePerSecond = 0;
                }


            }
            
        }

        public bool getUnrecognisedVoiceTone()
        {
            return unrecognisedVoiceTone;
        }

        public void setUnrecognisedVoiceTone( bool arg)
        {
            unrecognisedVoiceTone = arg;
        }

        /// <summary>
        /// Render time domain to PictureBox
        /// </summary>
        /// <param name="pictureBox"></param>
        public void RenderTimeDomainLeft(ref PictureBox pictureBox)
        {
            // Set up for drawing
            Bitmap canvas = new Bitmap(pictureBox.Width, pictureBox.Height);
            Graphics offScreenDC = Graphics.FromImage(canvas);
            Pen pen = new System.Drawing.Pen(Color.WhiteSmoke);

            // Determine channnel boundries
            int width = canvas.Width;
            int height = canvas.Height;
            double center = height / 2;

            // Draw left channel
            double scale = 0.5 * height / 32768;  // a 16 bit sample has values from -32768 to 32767
            int xPrev = 0, yPrev = 0;
            for (int x = 0; x < width; x++)
            {
                int y = (int)(center + (_waveLeft[_waveLeft.Length / width * x] * scale));
                if (x == 0)
                {
                    xPrev = 0;
                    yPrev = y;
                }
                else
                {
                    pen.Color = Color.Green;
                    offScreenDC.DrawLine(pen, xPrev, yPrev, x, y);
                    xPrev = x;
                    yPrev = y;
                }
            }

            // Clean up
            pictureBox.Image = canvas;
            offScreenDC.Dispose();
        }
        /// <summary>
        /// Render time domain to PictureBox
        /// </summary>
        /// <param name="pictureBox"></param>
        public void RenderTimeDomainRight(ref PictureBox pictureBox)
        {
            // Set up for drawing
            Bitmap canvas = new Bitmap(pictureBox.Width, pictureBox.Height);
            Graphics offScreenDC = Graphics.FromImage(canvas);
            Pen pen = new System.Drawing.Pen(Color.WhiteSmoke);

            // Determine channnel boundries
            int width = canvas.Width;
            int height = canvas.Height;
            double center = height / 2;

            // Draw left channel
            double scale = 0.5 * height / 32768;  // a 16 bit sample has values from -32768 to 32767
            int xPrev = 0, yPrev = 0;
            for (int x = 0; x < width; x++)
            {
                int y = (int)(center + (_waveRight[_waveRight.Length / width * x] * scale));
                if (x == 0)
                {
                    xPrev = 0;
                    yPrev = y;
                }
                else
                {
                    pen.Color = Color.Green;
                    offScreenDC.DrawLine(pen, xPrev, yPrev, x, y);
                    xPrev = x;
                    yPrev = y;
                }
            }

            // Clean up
            pictureBox.Image = canvas;
            offScreenDC.Dispose();
        }

        public static void setTakeSample(bool value)
        {
            takeSample = value;
            initialTime = DateTime.Now;
            output = new FileStream("sample.txt", FileMode.Append, FileAccess.Write, FileShare.Write);

            String _text = Environment.NewLine +  Environment.NewLine + "Sample name : " + sampleNameTextBox.Text ;
            Byte[] text = new UTF8Encoding(true).GetBytes(_text);
            output.Write(text, 0, text.Length);
        }

        public static void setRecordInteraction(bool value)
        {
            recordInteraction = value;
            interactInitialTime = DateTime.Now;
        }

        public static void playBeep()
        {
            myPlayer = new System.Media.SoundPlayer();
            myPlayer.SoundLocation = "ding.wav";
            myPlayer.Play();

        }

        public static void playHonk()
        {
            myPlayer = new System.Media.SoundPlayer();
            myPlayer.SoundLocation = "honk.wav";
            myPlayer.Play();
        }

        public NeuralNetwork getNeuralNetwork()
        {
            return neuralNetwork;
        }

        public void setNeuralNetwork(NeuralNetwork networkArg)
        {
            neuralNetwork = networkArg;
        }

        public void setRobot(Robot robotArg)
        {
            robot = robotArg;
        }


      
    }
}
