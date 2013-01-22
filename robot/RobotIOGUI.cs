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
     * This class creates the GUI which displays the inputs/outputs of the robot during interaction
     * 
     */
    public partial class RobotIOGUI : Form
    {
        // constructor
        public RobotIOGUI()
        {
            InitializeComponent();
        }

        // update gui
        public void updateGUI(String voiceToneInput, String proximityInput, String categoryOutput, String responseOutput)
        {
            voiceToneTextBox.Text = voiceToneInput;
            proximityTextBox.Text = proximityInput;
            categoryTextBox.Text = categoryOutput;
            responseTextBox.Text = responseOutput;
        }

        private void voiceToneTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void voiceToneLabel_Click(object sender, EventArgs e)
        {

        }

        private void proximityTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void proximityLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
