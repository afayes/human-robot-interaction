using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace robot
{
    /*
     * This class creates the GUI for controlling the robot
     * 
     */
    public partial class ControlRobotGUI : Form
    {
        // declaration of variables
        private USB_UIRT uSBUIRT;
        private bool sonicSensorsDisabled;
        private bool visionSensorsDisabled;

        // constructor
        public ControlRobotGUI()
        {
            uSBUIRT = new USB_UIRT();
            sonicSensorsDisabled  = false; ;
            visionSensorsDisabled = false;
            InitializeComponent();

        }

        private void ControlRobotGUI_Load(object sender, EventArgs e)
        {

        }

        private void instructRobotButton_Click(object sender, EventArgs e)
        {
            String action = robotActionsListBox.Text;
            uSBUIRT.transmitAction(action);

        }

        // disable/enable robots sonic sensors
        private void sonicSensorButton_Click(object sender, EventArgs e)
        {
            uSBUIRT.transmitCode("0000 006C 0000 000D 0100 0021 0020 0021 0020 0083 0020 0083 0020 0084 0020 0022 0020 0022 0020 0022 0020 0022 0020 0022 0020 0084 0020 0084 0020 3900");
            if (sonicSensorsDisabled)
            {
                sonicSensorsDisabled = false;
                sonicSesnorButton.Text = "Disable Sonic Sensors";
            }

            else
            {
                sonicSensorsDisabled = true;
                sonicSesnorButton.Text = "Enable Sonic Sensors";
            }
        }

        //disable/enable robots vision sensors
        private void visionButton_Click(object sender, EventArgs e)
        {
            uSBUIRT.transmitCode("0000 006B 0000 000D 0101 0022 0020 0022 0020 0084 0020 0084 0020 0084 0020 0022 0020 0022 0020 0022 0020 0022 0020 0022 0020 0022 0020 0022 0020 2D06");
            if (visionSensorsDisabled)
            { 
                visionSensorsDisabled = false;
                visionButton.Text = "Disable Vision Sensors";
            }

            else
            {
                visionSensorsDisabled = true;
                visionButton.Text = "Enable Vision Sensors";
            }
        }
    }
}
