using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SoundCatcher;
using vision;
using robot;
using neuralNetwork;
using System.Threading;

namespace interaction
{
    /*
     * This class creates the GUI for the start-up menu
     * 
     */

    public partial class MainMenuGUI : Form
    {
        // declaration of variables
        private SoundGUI soundGUI;
        private VisionGUI visionGUI;
        private BayesianNetworkGUI bayesianNetwokGUI;
        private NeuralNetworkGUI neuralNetworkGUI;
        private Robot robot;
        private ControlRobotGUI controlRobotGUI;
        
        //constructor
        public MainMenuGUI()
        {
            InitializeComponent();
            robot = new Robot();
        }

        // starts the visiosn system
        public void runVisionSystem()
        {
            visionGUI = new VisionGUI();
            visionGUI.setRobot(robot);
            Application.Run(visionGUI);
            
        }

        // starts the sound system
        public void runSoundSystem()
        {
            soundGUI = new SoundGUI();
            soundGUI.setRobot(robot);
            Application.Run(soundGUI);
        }
        //starts the neural netwrok system
        public void runNeuralNetwork()
        {
            neuralNetworkGUI = new NeuralNetworkGUI();
            Application.Run(neuralNetworkGUI);
        }

        // starts the bayesian network personality system
        public void runBayesianNetwork()
        {
            bayesianNetwokGUI = new BayesianNetworkGUI();
            Application.Run(bayesianNetwokGUI);
        }

        // starts the control robot program
        public void runControlRobotGUI()
        {
            controlRobotGUI = new ControlRobotGUI();
             Application.Run(controlRobotGUI);
        }

        // starts the robot IO program
        public void runRobotIOGUI()
        {  
            Application.Run(robot.getRobotGUI());
        }

        /*
         * below are action listeners for the button events  
         * 
         */
        
        private void bayesianNetworkButton_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(runBayesianNetwork);    
            thread.Start();
        }

        private void neuralNetworkButton_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(runNeuralNetwork);
            thread.Start();
        }

        private void soundSystemButton_Click(object sender, EventArgs e)
        {

            Thread thread = new Thread(runSoundSystem);
            thread.Start();
        }

        private void visionSystemButton_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(runVisionSystem);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void interactionModeButton1_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(runSoundSystem);
            thread.Start();

            Thread thread2 = new Thread(runVisionSystem);
            thread2.SetApartmentState(ApartmentState.STA);
            thread2.Start();

            Thread thread3 = new Thread(runRobotIOGUI);
            thread3.Start();


        }

        private void controlRobotButton_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(runControlRobotGUI);
            thread.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
