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
     * This class creates the GUI for interacting with the Bayesian network personality   
     * 
     */
    public partial class BayesianNetworkGUI : Form
    {
        // declaration of variables
        BayesianNetwork_Personality personality;
        RadioButton[] inputRadioButtons;
        TextBox[] outputTextBoxes;
        Label[] outputLabels;

        // constructor
        public BayesianNetworkGUI()
        {
            InitializeComponent();
            personality = new BayesianNetwork_Personality();    
            RadioButton[] tempRB = { angryRadioButton, happyRadioButton, sadRadioButton, neutralRadioButton, farRadioButton, mediumRadioButton, closeRadioButton };
            inputRadioButtons = tempRB;

            TextBox[] tempTB = { defensiveTextBox, aggressiveTextBox, intimidatingOrProtectiveTextBox, intimacyTextBox, friendlyTextBox, interestTextBox, defensiveOrIntimacyTextBox, disinterestTextBox };
            outputTextBoxes = tempTB;

            Label[] tempL = { defensiveLabel, aggressiveLabel, intimidatingOrProtectiveLabel, intimacyLabel, friendlyLabel, interestLabel, defensiveOrIntimacyLabel, disinterestLabel };
            outputLabels = tempL;

            reset();
        }

        // retract evidence from the network
        public void reset()
        {
            for (int i = 0; i < inputRadioButtons.Length; i++)
            {
                inputRadioButtons[i].Checked = false;
            }

            for (int i = 0; i < outputTextBoxes.Length; i++)
            {
                outputTextBoxes[i].Text = "";
            }

            personality.retractEvidence();
            recalculate();

        }

        // update robot response probabilities
        public void recalculate()
        {
            inputEvidence();
            double[] beliefs = personality.updateBeliefs();
            for (int i = 0; i < outputTextBoxes.Length; i++)
            {
                outputTextBoxes[i].Text = beliefs[i] + "";

            }
            
            personality.retractEvidence();

            int index = personality.getHighestBeliefStateIndex();
            mostLikeyAnswerLabel.Text = outputLabels[index].Text;
           
        }

        // input evidence into the network
        public void inputEvidence()
        {
            for (int i = 0; i < 4; i++ )
            {
                if(inputRadioButtons[i].Checked)
                {
                    personality.enterEvidenceVoiceTone(inputRadioButtons[i].Text);
                }
            }

            for (int i = 4; i < inputRadioButtons.Length; i++ )
            {
                if (inputRadioButtons[i].Checked)
                {
                    personality.enterEvidenceProximity(inputRadioButtons[i].Text);
                }
            }
        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void aggressiveLabel_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        // reset the gui and retract evidence
        private void resetButton_Click(object sender, EventArgs e)
        {
            reset();
        }

        // update robot response probabilities
        private void recalculateButton_Click(object sender, EventArgs e)
        {
            recalculate();
              
        }
    }
}
