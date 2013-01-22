using System;
using System.Drawing;
using System.Windows.Forms;
using robot;

namespace vision
{
    /*
     * This class creates the GUI for the vision system 
     * 
     */
    public partial class VisionGUI : Form
    {
        // declaration of variables
        private Bitmap previousFrame = null;
        private ImageProcessing imageProcessing;
        private GestureRecognition gestureRecognition;
        private DateTime initialTime;
        private bool interactionReady;
        private int waitingTime;
        private bool interact = false;
        private Robot robot;
        private String currentProximity;
        private String previousProximity; 

        // constructor
        public VisionGUI()
        {
            imageProcessing = new ImageProcessing();
            gestureRecognition = new GestureRecognition();
            interactionReady = false;
            currentProximity = "";
            previousProximity = "";
            InitializeComponent();
        }

        private void mainWindow_Load(object sender, EventArgs e)
        {

        }

        // image received from web cam
        private void WebCamCapture_ImageCaptured(object source, WebCam_Capture.WebcamEventArgs e)
        {
            Bitmap image = new Bitmap(e.WebCamImage);
            Bitmap currentFrame = image;
            Bitmap differenceImage = null;
            Bitmap thresholdImage = null;
            Bitmap findBodyAndHandColours = null;
            Bitmap model = null;

            

            if(previousFrame != null)
            {
                
                Bitmap grayScaledCurrent = imageProcessing.grayscale(currentFrame);
                Bitmap grayScaledPrevious = imageProcessing.grayscale(previousFrame);

                Bitmap averagedCurrent = imageProcessing.averaging(grayScaledCurrent);
                Bitmap averagedPrevious = imageProcessing.averaging(grayScaledPrevious);

                differenceImage = imageProcessing.subtraction(averagedCurrent, averagedPrevious);
                thresholdImage = imageProcessing.iterativeThreshold(differenceImage);
                findBodyAndHandColours = imageProcessing.findBodyAndHand(currentFrame);
                gestureRecognition.makeModel(findBodyAndHandColours);
                model = gestureRecognition.drawModel(240, 320);

                if(interact)
                {
                    DateTime currentTime = DateTime.Now;
                    int difference = (currentTime - initialTime).Seconds;
                    if (!interactionReady)
                    {
                        interactionTimeLabel.Text = waitingTime - difference + " seconds till interaction ";
                        if (difference >= waitingTime)
                        {
                            interactionReady = true;
                            gestureRecognition.setInteractionReady(true);
                            gestureRecognition.setPreviousLowestBodyYPosition();
                            interactionTimeLabel.Text = "Ready";
                        }
                    }

                    else
                    {
                        proxmityTextField.Text = gestureRecognition.getProximity();
                        approachingDetractingTextField.Text = gestureRecognition.getApproachingOrDetracting();
                        handGestureTextField.Text = gestureRecognition.getHandGesture();
                        gestureRecognition.calculateBodyMotion(thresholdImage);
                        motionLevelTextField.Text = (gestureRecognition.getMotionLevel()) + " %";

                        currentProximity = gestureRecognition.getProximity();
                        if(currentProximity != previousProximity)
                        {
                            if(robot.getIsSeeing())
                            {
                                robot.see(currentProximity);
                                previousProximity = currentProximity;
                            }
                        }
                    }
                }
               
                
                

            }
            if (currentFrameCheckBox.Checked)
            {
                currentImage.Image = currentFrame;
            }
            else
            {
                currentImage.Image = null;
            }
            if (motionDetectionCheckBox.Checked)
            {
                motionImage.Image = thresholdImage;
            }
            else
            {
                motionImage.Image = null;
            }

            if (colorDetectionCheckBox.Checked)
            {
                colordetectionImage.Image = findBodyAndHandColours;
            }
            else
            {
                colordetectionImage.Image = null;

            }

            if (modelCheckBox.Checked)
            {
                modelImage.Image = model;
            }

            else
            {
                modelImage.Image = null;
            }
           
            previousFrame = currentFrame;

        }

        public void setRobot(Robot robotArg)
        {
            robot = robotArg;
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.Run(new VisionGUI());


        }

        // action listener for start button
        private void startButton_Click(object sender, EventArgs e)
        {     

            // start the video capture
            this.capture.Start(0);
            
        }

        // action listener for stop button
        private void stopButton_Click(object sender, EventArgs e)
        {
            // stop the video capture
            this.capture.Stop();
        }

        // action listener for resume button
        private void continueButton_Click(object sender, EventArgs e)
        {
          
            // resume the video capture
            this.capture.Start(this.capture.FrameNumber);
        }

        private void image1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void secondsLabel_Click(object sender, EventArgs e)
        {

        }

        // action listener for interact button
        private void interactButton_Click(object sender, EventArgs e)
        {
            waitingTime = int.Parse(waitingTimeText.Text);
            interact = true;
            initialTime = DateTime.Now;
        }

        private void waitingTimeText_TextChanged(object sender, EventArgs e)
        {

        }

        private void waitTimeLabel_Click(object sender, EventArgs e)
        {

        }

        private void interactionTimeLabel_Click(object sender, EventArgs e)
        {

        }


    }
}
