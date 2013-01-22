using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using AForge.Neuro.Learning;
using AForge.Neuro;
using System.Threading;

namespace neuralNetwork
{
    public partial class NeuralNetworkGUI : Form
    {
        /*
         *  This class creates the GUI for interacting with the neural network 
         * 
         */

        // declaration of variables
        NeuralNetwork neuralNetwork;  
        private Thread workerThread = null;
        
        // constructor
        public NeuralNetworkGUI()
        {
            InitializeComponent();
            neuralNetwork = new NeuralNetwork();
            neuralNetwork.setOutputErrorComponent(errorLabel);
            defaultSettings();       
        }

        // reset network configuration settings
        public void defaultSettings()
        {
            neuralNetwork.defaultSettings();
            learningRateText.Text = neuralNetwork.getLearningRate() +  "";
            momentumText.Text =  neuralNetwork.getMomentum() +  "";
            sigmoidAVText.Text =  neuralNetwork.getSigmoidAV() +  "";
            iterationText.Text =  neuralNetwork.getIteration() +  "";
            randomiseCheckBox.Checked = neuralNetwork.getRandomiseInputData();
            randomMomentumCheckBox.Checked =  neuralNetwork.getRandomMomentum();
              
        }



        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void configuationLabel_Enter(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        // action listener for learn button
        private void learnButton_Click(object sender, EventArgs e)
        {
            double learningRateArg = double.Parse(learningRateText.Text) ;
            double momentumArg = double.Parse(momentumText.Text);
            double sigmoidAVArg = double.Parse(sigmoidAVText.Text);
            double iterationArg = double.Parse(iterationText.Text);
            Boolean randomiseInputDataArg = randomiseCheckBox.Checked;
            Boolean randomMomentumArg = randomMomentumCheckBox.Checked;
            
            neuralNetwork.setConfiguration( learningRateArg,  momentumArg,  sigmoidAVArg,  iterationArg,  randomiseInputDataArg,  randomMomentumArg);
            
            workerThread = new Thread(new ThreadStart( neuralNetwork.learn));
            workerThread.Start();
             
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        // action listener for test network button
        private void testButton_Click(object sender, EventArgs e)
        {
            //int[] correctArray = { correctCounter, incorrectCounter };
            int[] correctArray = neuralNetwork.test();
            correctLabel.Text = "Correct output = " + correctArray[0] + " " + "Incorrect output = " + correctArray[1];
          
        }
        // action listener for resetting settings button
        private void defaultSettingsButton_Click(object sender, EventArgs e)
        {
            defaultSettings();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        // action listener for reducing error button
        private void reduceErrorButton_Click(object sender, EventArgs e)
        {
            double learningRateArg = double.Parse(learningRateText.Text);
            double momentumArg = double.Parse(momentumText.Text);
            double sigmoidAVArg = double.Parse(sigmoidAVText.Text);
            double iterationArg = double.Parse(iterationText.Text);
            Boolean randomiseInputDataArg = randomiseCheckBox.Checked;
            Boolean randomMomentumArg = randomMomentumCheckBox.Checked;

            neuralNetwork.setConfiguration(learningRateArg, momentumArg, sigmoidAVArg, iterationArg, randomiseInputDataArg, randomMomentumArg);

            workerThread = new Thread(new ThreadStart(neuralNetwork.reduceError));
            workerThread.Start();
        }

       
    }
}
