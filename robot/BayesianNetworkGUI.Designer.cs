namespace robot
{
    partial class BayesianNetworkGUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.recalculateButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.closeRadioButton = new System.Windows.Forms.RadioButton();
            this.mediumRadioButton = new System.Windows.Forms.RadioButton();
            this.farRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.neutralRadioButton = new System.Windows.Forms.RadioButton();
            this.sadRadioButton = new System.Windows.Forms.RadioButton();
            this.happyRadioButton = new System.Windows.Forms.RadioButton();
            this.angryRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mostLikeyAnswerLabel = new System.Windows.Forms.Label();
            this.mostLikelyLabel = new System.Windows.Forms.Label();
            this.disinterestTextBox = new System.Windows.Forms.TextBox();
            this.defensiveOrIntimacyTextBox = new System.Windows.Forms.TextBox();
            this.interestTextBox = new System.Windows.Forms.TextBox();
            this.friendlyTextBox = new System.Windows.Forms.TextBox();
            this.intimacyTextBox = new System.Windows.Forms.TextBox();
            this.intimidatingOrProtectiveTextBox = new System.Windows.Forms.TextBox();
            this.aggressiveTextBox = new System.Windows.Forms.TextBox();
            this.defensiveTextBox = new System.Windows.Forms.TextBox();
            this.disinterestLabel = new System.Windows.Forms.Label();
            this.defensiveOrIntimacyLabel = new System.Windows.Forms.Label();
            this.interestLabel = new System.Windows.Forms.Label();
            this.friendlyLabel = new System.Windows.Forms.Label();
            this.intimacyLabel = new System.Windows.Forms.Label();
            this.intimidatingOrProtectiveLabel = new System.Windows.Forms.Label();
            this.aggressiveLabel = new System.Windows.Forms.Label();
            this.defensiveLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Location = new System.Drawing.Point(21, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 313);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.recalculateButton);
            this.groupBox5.Controls.Add(this.resetButton);
            this.groupBox5.Location = new System.Drawing.Point(17, 195);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(307, 101);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Controls";
            // 
            // recalculateButton
            // 
            this.recalculateButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.recalculateButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.recalculateButton.Location = new System.Drawing.Point(88, 19);
            this.recalculateButton.Name = "recalculateButton";
            this.recalculateButton.Size = new System.Drawing.Size(111, 26);
            this.recalculateButton.TabIndex = 7;
            this.recalculateButton.Text = "Recalculate";
            this.recalculateButton.UseVisualStyleBackColor = false;
            this.recalculateButton.Click += new System.EventHandler(this.recalculateButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.resetButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.resetButton.Location = new System.Drawing.Point(88, 56);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(111, 26);
            this.resetButton.TabIndex = 6;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.closeRadioButton);
            this.groupBox4.Controls.Add(this.mediumRadioButton);
            this.groupBox4.Controls.Add(this.farRadioButton);
            this.groupBox4.Location = new System.Drawing.Point(172, 31);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(152, 147);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Proximity";
            // 
            // closeRadioButton
            // 
            this.closeRadioButton.AutoSize = true;
            this.closeRadioButton.Location = new System.Drawing.Point(17, 72);
            this.closeRadioButton.Name = "closeRadioButton";
            this.closeRadioButton.Size = new System.Drawing.Size(51, 17);
            this.closeRadioButton.TabIndex = 3;
            this.closeRadioButton.TabStop = true;
            this.closeRadioButton.Text = "Close";
            this.closeRadioButton.UseVisualStyleBackColor = true;
            // 
            // mediumRadioButton
            // 
            this.mediumRadioButton.AutoSize = true;
            this.mediumRadioButton.Location = new System.Drawing.Point(17, 49);
            this.mediumRadioButton.Name = "mediumRadioButton";
            this.mediumRadioButton.Size = new System.Drawing.Size(62, 17);
            this.mediumRadioButton.TabIndex = 2;
            this.mediumRadioButton.TabStop = true;
            this.mediumRadioButton.Text = "Medium";
            this.mediumRadioButton.UseVisualStyleBackColor = true;
            // 
            // farRadioButton
            // 
            this.farRadioButton.AutoSize = true;
            this.farRadioButton.Location = new System.Drawing.Point(17, 26);
            this.farRadioButton.Name = "farRadioButton";
            this.farRadioButton.Size = new System.Drawing.Size(40, 17);
            this.farRadioButton.TabIndex = 0;
            this.farRadioButton.TabStop = true;
            this.farRadioButton.Text = "Far";
            this.farRadioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.neutralRadioButton);
            this.groupBox3.Controls.Add(this.sadRadioButton);
            this.groupBox3.Controls.Add(this.happyRadioButton);
            this.groupBox3.Controls.Add(this.angryRadioButton);
            this.groupBox3.Location = new System.Drawing.Point(15, 31);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(142, 147);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Voice Tone";
            // 
            // neutralRadioButton
            // 
            this.neutralRadioButton.AutoSize = true;
            this.neutralRadioButton.Location = new System.Drawing.Point(16, 95);
            this.neutralRadioButton.Name = "neutralRadioButton";
            this.neutralRadioButton.Size = new System.Drawing.Size(59, 17);
            this.neutralRadioButton.TabIndex = 5;
            this.neutralRadioButton.TabStop = true;
            this.neutralRadioButton.Text = "Neutral";
            this.neutralRadioButton.UseVisualStyleBackColor = true;
            // 
            // sadRadioButton
            // 
            this.sadRadioButton.AutoSize = true;
            this.sadRadioButton.Location = new System.Drawing.Point(16, 72);
            this.sadRadioButton.Name = "sadRadioButton";
            this.sadRadioButton.Size = new System.Drawing.Size(44, 17);
            this.sadRadioButton.TabIndex = 4;
            this.sadRadioButton.TabStop = true;
            this.sadRadioButton.Text = "Sad";
            this.sadRadioButton.UseVisualStyleBackColor = true;
            // 
            // happyRadioButton
            // 
            this.happyRadioButton.AutoSize = true;
            this.happyRadioButton.Location = new System.Drawing.Point(16, 49);
            this.happyRadioButton.Name = "happyRadioButton";
            this.happyRadioButton.Size = new System.Drawing.Size(56, 17);
            this.happyRadioButton.TabIndex = 3;
            this.happyRadioButton.TabStop = true;
            this.happyRadioButton.Text = "Happy";
            this.happyRadioButton.UseVisualStyleBackColor = true;
            // 
            // angryRadioButton
            // 
            this.angryRadioButton.AutoSize = true;
            this.angryRadioButton.Location = new System.Drawing.Point(16, 26);
            this.angryRadioButton.Name = "angryRadioButton";
            this.angryRadioButton.Size = new System.Drawing.Size(52, 17);
            this.angryRadioButton.TabIndex = 2;
            this.angryRadioButton.TabStop = true;
            this.angryRadioButton.Text = "Angry";
            this.angryRadioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.mostLikeyAnswerLabel);
            this.groupBox2.Controls.Add(this.mostLikelyLabel);
            this.groupBox2.Controls.Add(this.disinterestTextBox);
            this.groupBox2.Controls.Add(this.defensiveOrIntimacyTextBox);
            this.groupBox2.Controls.Add(this.interestTextBox);
            this.groupBox2.Controls.Add(this.friendlyTextBox);
            this.groupBox2.Controls.Add(this.intimacyTextBox);
            this.groupBox2.Controls.Add(this.intimidatingOrProtectiveTextBox);
            this.groupBox2.Controls.Add(this.aggressiveTextBox);
            this.groupBox2.Controls.Add(this.defensiveTextBox);
            this.groupBox2.Controls.Add(this.disinterestLabel);
            this.groupBox2.Controls.Add(this.defensiveOrIntimacyLabel);
            this.groupBox2.Controls.Add(this.interestLabel);
            this.groupBox2.Controls.Add(this.friendlyLabel);
            this.groupBox2.Controls.Add(this.intimacyLabel);
            this.groupBox2.Controls.Add(this.intimidatingOrProtectiveLabel);
            this.groupBox2.Controls.Add(this.aggressiveLabel);
            this.groupBox2.Controls.Add(this.defensiveLabel);
            this.groupBox2.Location = new System.Drawing.Point(414, 34);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(313, 303);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Output";
            // 
            // mostLikeyAnswerLabel
            // 
            this.mostLikeyAnswerLabel.AutoSize = true;
            this.mostLikeyAnswerLabel.Location = new System.Drawing.Point(158, 261);
            this.mostLikeyAnswerLabel.Name = "mostLikeyAnswerLabel";
            this.mostLikeyAnswerLabel.Size = new System.Drawing.Size(0, 13);
            this.mostLikeyAnswerLabel.TabIndex = 17;
            // 
            // mostLikelyLabel
            // 
            this.mostLikelyLabel.AutoSize = true;
            this.mostLikelyLabel.Location = new System.Drawing.Point(25, 264);
            this.mostLikelyLabel.Name = "mostLikelyLabel";
            this.mostLikelyLabel.Size = new System.Drawing.Size(92, 13);
            this.mostLikelyLabel.TabIndex = 16;
            this.mostLikelyLabel.Text = "Most likely output:";
            // 
            // disinterestTextBox
            // 
            this.disinterestTextBox.Location = new System.Drawing.Point(156, 229);
            this.disinterestTextBox.Name = "disinterestTextBox";
            this.disinterestTextBox.Size = new System.Drawing.Size(86, 20);
            this.disinterestTextBox.TabIndex = 15;
            this.disinterestTextBox.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // defensiveOrIntimacyTextBox
            // 
            this.defensiveOrIntimacyTextBox.Location = new System.Drawing.Point(156, 201);
            this.defensiveOrIntimacyTextBox.Name = "defensiveOrIntimacyTextBox";
            this.defensiveOrIntimacyTextBox.Size = new System.Drawing.Size(86, 20);
            this.defensiveOrIntimacyTextBox.TabIndex = 14;
            // 
            // interestTextBox
            // 
            this.interestTextBox.Location = new System.Drawing.Point(156, 175);
            this.interestTextBox.Name = "interestTextBox";
            this.interestTextBox.Size = new System.Drawing.Size(86, 20);
            this.interestTextBox.TabIndex = 13;
            this.interestTextBox.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // friendlyTextBox
            // 
            this.friendlyTextBox.Location = new System.Drawing.Point(156, 145);
            this.friendlyTextBox.Name = "friendlyTextBox";
            this.friendlyTextBox.Size = new System.Drawing.Size(86, 20);
            this.friendlyTextBox.TabIndex = 12;
            // 
            // intimacyTextBox
            // 
            this.intimacyTextBox.Location = new System.Drawing.Point(156, 116);
            this.intimacyTextBox.Name = "intimacyTextBox";
            this.intimacyTextBox.Size = new System.Drawing.Size(86, 20);
            this.intimacyTextBox.TabIndex = 11;
            // 
            // intimidatingOrProtectiveTextBox
            // 
            this.intimidatingOrProtectiveTextBox.Location = new System.Drawing.Point(156, 88);
            this.intimidatingOrProtectiveTextBox.Name = "intimidatingOrProtectiveTextBox";
            this.intimidatingOrProtectiveTextBox.Size = new System.Drawing.Size(86, 20);
            this.intimidatingOrProtectiveTextBox.TabIndex = 10;
            // 
            // aggressiveTextBox
            // 
            this.aggressiveTextBox.Location = new System.Drawing.Point(156, 58);
            this.aggressiveTextBox.Name = "aggressiveTextBox";
            this.aggressiveTextBox.Size = new System.Drawing.Size(86, 20);
            this.aggressiveTextBox.TabIndex = 9;
            this.aggressiveTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // defensiveTextBox
            // 
            this.defensiveTextBox.Location = new System.Drawing.Point(156, 29);
            this.defensiveTextBox.Name = "defensiveTextBox";
            this.defensiveTextBox.Size = new System.Drawing.Size(86, 20);
            this.defensiveTextBox.TabIndex = 8;
            // 
            // disinterestLabel
            // 
            this.disinterestLabel.AutoSize = true;
            this.disinterestLabel.Location = new System.Drawing.Point(23, 232);
            this.disinterestLabel.Name = "disinterestLabel";
            this.disinterestLabel.Size = new System.Drawing.Size(56, 13);
            this.disinterestLabel.TabIndex = 7;
            this.disinterestLabel.Text = "Disinterest";
            // 
            // defensiveOrIntimacyLabel
            // 
            this.defensiveOrIntimacyLabel.AutoSize = true;
            this.defensiveOrIntimacyLabel.Location = new System.Drawing.Point(22, 204);
            this.defensiveOrIntimacyLabel.Name = "defensiveOrIntimacyLabel";
            this.defensiveOrIntimacyLabel.Size = new System.Drawing.Size(108, 13);
            this.defensiveOrIntimacyLabel.TabIndex = 6;
            this.defensiveOrIntimacyLabel.Text = "Defensive or intimacy";
            // 
            // interestLabel
            // 
            this.interestLabel.AutoSize = true;
            this.interestLabel.Location = new System.Drawing.Point(23, 178);
            this.interestLabel.Name = "interestLabel";
            this.interestLabel.Size = new System.Drawing.Size(42, 13);
            this.interestLabel.TabIndex = 5;
            this.interestLabel.Text = "Interest";
            this.interestLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // friendlyLabel
            // 
            this.friendlyLabel.AutoSize = true;
            this.friendlyLabel.Location = new System.Drawing.Point(22, 152);
            this.friendlyLabel.Name = "friendlyLabel";
            this.friendlyLabel.Size = new System.Drawing.Size(43, 13);
            this.friendlyLabel.TabIndex = 4;
            this.friendlyLabel.Text = "Friendly";
            this.friendlyLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // intimacyLabel
            // 
            this.intimacyLabel.AutoSize = true;
            this.intimacyLabel.Location = new System.Drawing.Point(22, 123);
            this.intimacyLabel.Name = "intimacyLabel";
            this.intimacyLabel.Size = new System.Drawing.Size(46, 13);
            this.intimacyLabel.TabIndex = 3;
            this.intimacyLabel.Text = "Intimacy";
            this.intimacyLabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // intimidatingOrProtectiveLabel
            // 
            this.intimidatingOrProtectiveLabel.AutoSize = true;
            this.intimidatingOrProtectiveLabel.Location = new System.Drawing.Point(22, 95);
            this.intimidatingOrProtectiveLabel.Name = "intimidatingOrProtectiveLabel";
            this.intimidatingOrProtectiveLabel.Size = new System.Drawing.Size(122, 13);
            this.intimidatingOrProtectiveLabel.TabIndex = 2;
            this.intimidatingOrProtectiveLabel.Text = "Intimidating or protective";
            // 
            // aggressiveLabel
            // 
            this.aggressiveLabel.AutoSize = true;
            this.aggressiveLabel.Location = new System.Drawing.Point(22, 61);
            this.aggressiveLabel.Name = "aggressiveLabel";
            this.aggressiveLabel.Size = new System.Drawing.Size(59, 13);
            this.aggressiveLabel.TabIndex = 1;
            this.aggressiveLabel.Text = "Aggressive";
            this.aggressiveLabel.Click += new System.EventHandler(this.aggressiveLabel_Click);
            // 
            // defensiveLabel
            // 
            this.defensiveLabel.AutoSize = true;
            this.defensiveLabel.Location = new System.Drawing.Point(22, 32);
            this.defensiveLabel.Name = "defensiveLabel";
            this.defensiveLabel.Size = new System.Drawing.Size(55, 13);
            this.defensiveLabel.TabIndex = 0;
            this.defensiveLabel.Text = "Defensive";
            // 
            // BayesianNetworkGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(774, 400);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.Red;
            this.Name = "BayesianNetworkGUI";
            this.Text = "Bayesian Network";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton happyRadioButton;
        private System.Windows.Forms.RadioButton angryRadioButton;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton farRadioButton;
        private System.Windows.Forms.RadioButton sadRadioButton;
        private System.Windows.Forms.RadioButton neutralRadioButton;
        private System.Windows.Forms.RadioButton closeRadioButton;
        private System.Windows.Forms.RadioButton mediumRadioButton;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button recalculateButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label defensiveLabel;
        private System.Windows.Forms.Label interestLabel;
        private System.Windows.Forms.Label friendlyLabel;
        private System.Windows.Forms.Label intimacyLabel;
        private System.Windows.Forms.Label intimidatingOrProtectiveLabel;
        private System.Windows.Forms.Label aggressiveLabel;
        private System.Windows.Forms.Label disinterestLabel;
        private System.Windows.Forms.Label defensiveOrIntimacyLabel;
        private System.Windows.Forms.TextBox interestTextBox;
        private System.Windows.Forms.TextBox friendlyTextBox;
        private System.Windows.Forms.TextBox intimacyTextBox;
        private System.Windows.Forms.TextBox intimidatingOrProtectiveTextBox;
        private System.Windows.Forms.TextBox aggressiveTextBox;
        private System.Windows.Forms.TextBox defensiveTextBox;
        private System.Windows.Forms.TextBox disinterestTextBox;
        private System.Windows.Forms.TextBox defensiveOrIntimacyTextBox;
        private System.Windows.Forms.Label mostLikelyLabel;
        private System.Windows.Forms.Label mostLikeyAnswerLabel;
    }
}