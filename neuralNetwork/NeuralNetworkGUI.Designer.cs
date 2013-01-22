namespace neuralNetwork
{
    partial class NeuralNetworkGUI
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
            this.learningRateLabel = new System.Windows.Forms.Label();
            this.momentumLabel = new System.Windows.Forms.Label();
            this.sigmoidAVLabel = new System.Windows.Forms.Label();
            this.iterationLabel = new System.Windows.Forms.Label();
            this.sigmoidAVText = new System.Windows.Forms.TextBox();
            this.momentumText = new System.Windows.Forms.TextBox();
            this.iterationText = new System.Windows.Forms.TextBox();
            this.learningRateText = new System.Windows.Forms.TextBox();
            this.learnButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.defaultSettingsButton = new System.Windows.Forms.Button();
            this.randomMomentumCheckBox = new System.Windows.Forms.CheckBox();
            this.randomiseCheckBox = new System.Windows.Forms.CheckBox();
            this.randomiseLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.reduceErrorButton = new System.Windows.Forms.Button();
            this.testButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.correctLabel = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // learningRateLabel
            // 
            this.learningRateLabel.AutoSize = true;
            this.learningRateLabel.Location = new System.Drawing.Point(29, 32);
            this.learningRateLabel.Name = "learningRateLabel";
            this.learningRateLabel.Size = new System.Drawing.Size(69, 13);
            this.learningRateLabel.TabIndex = 0;
            this.learningRateLabel.Text = "Learning rate";
            // 
            // momentumLabel
            // 
            this.momentumLabel.AutoSize = true;
            this.momentumLabel.Location = new System.Drawing.Point(29, 69);
            this.momentumLabel.Name = "momentumLabel";
            this.momentumLabel.Size = new System.Drawing.Size(59, 13);
            this.momentumLabel.TabIndex = 1;
            this.momentumLabel.Text = "Momentum";
            // 
            // sigmoidAVLabel
            // 
            this.sigmoidAVLabel.AutoSize = true;
            this.sigmoidAVLabel.Location = new System.Drawing.Point(29, 107);
            this.sigmoidAVLabel.Name = "sigmoidAVLabel";
            this.sigmoidAVLabel.Size = new System.Drawing.Size(109, 13);
            this.sigmoidAVLabel.TabIndex = 2;
            this.sigmoidAVLabel.Text = "Sigmoid\'s alpha value";
            // 
            // iterationLabel
            // 
            this.iterationLabel.AutoSize = true;
            this.iterationLabel.Location = new System.Drawing.Point(29, 143);
            this.iterationLabel.Name = "iterationLabel";
            this.iterationLabel.Size = new System.Drawing.Size(50, 13);
            this.iterationLabel.TabIndex = 3;
            this.iterationLabel.Text = "Iterations";
            // 
            // sigmoidAVText
            // 
            this.sigmoidAVText.Location = new System.Drawing.Point(168, 104);
            this.sigmoidAVText.Name = "sigmoidAVText";
            this.sigmoidAVText.Size = new System.Drawing.Size(92, 20);
            this.sigmoidAVText.TabIndex = 4;
            this.sigmoidAVText.Text = "2";
            // 
            // momentumText
            // 
            this.momentumText.Location = new System.Drawing.Point(168, 66);
            this.momentumText.Name = "momentumText";
            this.momentumText.Size = new System.Drawing.Size(92, 20);
            this.momentumText.TabIndex = 5;
            this.momentumText.Text = "0";
            // 
            // iterationText
            // 
            this.iterationText.Location = new System.Drawing.Point(168, 143);
            this.iterationText.Name = "iterationText";
            this.iterationText.Size = new System.Drawing.Size(92, 20);
            this.iterationText.TabIndex = 6;
            this.iterationText.Text = "1000";
            // 
            // learningRateText
            // 
            this.learningRateText.Location = new System.Drawing.Point(168, 29);
            this.learningRateText.Name = "learningRateText";
            this.learningRateText.Size = new System.Drawing.Size(92, 20);
            this.learningRateText.TabIndex = 7;
            this.learningRateText.Text = "0.1";
            this.learningRateText.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // learnButton
            // 
            this.learnButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.learnButton.ForeColor = System.Drawing.Color.White;
            this.learnButton.Location = new System.Drawing.Point(58, 29);
            this.learnButton.Name = "learnButton";
            this.learnButton.Size = new System.Drawing.Size(107, 27);
            this.learnButton.TabIndex = 0;
            this.learnButton.Text = "Learn";
            this.learnButton.UseVisualStyleBackColor = false;
            this.learnButton.Click += new System.EventHandler(this.learnButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.defaultSettingsButton);
            this.groupBox1.Controls.Add(this.randomMomentumCheckBox);
            this.groupBox1.Controls.Add(this.randomiseCheckBox);
            this.groupBox1.Controls.Add(this.randomiseLabel);
            this.groupBox1.Controls.Add(this.learningRateText);
            this.groupBox1.Controls.Add(this.learningRateLabel);
            this.groupBox1.Controls.Add(this.iterationText);
            this.groupBox1.Controls.Add(this.iterationLabel);
            this.groupBox1.Controls.Add(this.momentumText);
            this.groupBox1.Controls.Add(this.sigmoidAVText);
            this.groupBox1.Controls.Add(this.momentumLabel);
            this.groupBox1.Controls.Add(this.sigmoidAVLabel);
            this.groupBox1.Location = new System.Drawing.Point(33, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 249);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configuration";
            // 
            // defaultSettingsButton
            // 
            this.defaultSettingsButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.defaultSettingsButton.ForeColor = System.Drawing.Color.White;
            this.defaultSettingsButton.Location = new System.Drawing.Point(28, 211);
            this.defaultSettingsButton.Name = "defaultSettingsButton";
            this.defaultSettingsButton.Size = new System.Drawing.Size(110, 25);
            this.defaultSettingsButton.TabIndex = 11;
            this.defaultSettingsButton.Text = "Default";
            this.defaultSettingsButton.UseVisualStyleBackColor = false;
            this.defaultSettingsButton.Click += new System.EventHandler(this.defaultSettingsButton_Click);
            // 
            // randomMomentumCheckBox
            // 
            this.randomMomentumCheckBox.AutoSize = true;
            this.randomMomentumCheckBox.Location = new System.Drawing.Point(266, 69);
            this.randomMomentumCheckBox.Name = "randomMomentumCheckBox";
            this.randomMomentumCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.randomMomentumCheckBox.Size = new System.Drawing.Size(78, 17);
            this.randomMomentumCheckBox.TabIndex = 10;
            this.randomMomentumCheckBox.Text = "or Random";
            this.randomMomentumCheckBox.UseVisualStyleBackColor = true;
            // 
            // randomiseCheckBox
            // 
            this.randomiseCheckBox.AutoSize = true;
            this.randomiseCheckBox.Location = new System.Drawing.Point(168, 178);
            this.randomiseCheckBox.Name = "randomiseCheckBox";
            this.randomiseCheckBox.Size = new System.Drawing.Size(15, 14);
            this.randomiseCheckBox.TabIndex = 9;
            this.randomiseCheckBox.UseVisualStyleBackColor = true;
            // 
            // randomiseLabel
            // 
            this.randomiseLabel.AutoSize = true;
            this.randomiseLabel.Location = new System.Drawing.Point(29, 178);
            this.randomiseLabel.Name = "randomiseLabel";
            this.randomiseLabel.Size = new System.Drawing.Size(110, 13);
            this.randomiseLabel.TabIndex = 8;
            this.randomiseLabel.Text = "Randomise input data";
            this.randomiseLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.reduceErrorButton);
            this.groupBox2.Controls.Add(this.testButton);
            this.groupBox2.Controls.Add(this.learnButton);
            this.groupBox2.Location = new System.Drawing.Point(412, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(337, 121);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Controls";
            // 
            // reduceErrorButton
            // 
            this.reduceErrorButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.reduceErrorButton.ForeColor = System.Drawing.Color.White;
            this.reduceErrorButton.Location = new System.Drawing.Point(184, 29);
            this.reduceErrorButton.Name = "reduceErrorButton";
            this.reduceErrorButton.Size = new System.Drawing.Size(107, 27);
            this.reduceErrorButton.TabIndex = 11;
            this.reduceErrorButton.Text = "Reduce Error";
            this.reduceErrorButton.UseVisualStyleBackColor = false;
            this.reduceErrorButton.Click += new System.EventHandler(this.reduceErrorButton_Click);
            // 
            // testButton
            // 
            this.testButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.testButton.ForeColor = System.Drawing.Color.White;
            this.testButton.Location = new System.Drawing.Point(57, 75);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(107, 27);
            this.testButton.TabIndex = 10;
            this.testButton.Text = "Test";
            this.testButton.UseVisualStyleBackColor = false;
            this.testButton.Click += new System.EventHandler(this.testButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.correctLabel);
            this.groupBox3.Controls.Add(this.errorLabel);
            this.groupBox3.Location = new System.Drawing.Point(415, 158);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(334, 90);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Output";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // correctLabel
            // 
            this.correctLabel.Location = new System.Drawing.Point(26, 56);
            this.correctLabel.Name = "correctLabel";
            this.correctLabel.Size = new System.Drawing.Size(249, 31);
            this.correctLabel.TabIndex = 1;
            // 
            // errorLabel
            // 
            this.errorLabel.Location = new System.Drawing.Point(26, 32);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(300, 13);
            this.errorLabel.TabIndex = 0;
            // 
            // NeuralNetworkGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(772, 311);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.Red;
            this.Name = "NeuralNetworkGUI";
            this.Text = "Neural Network ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label iterationLabel;
        private System.Windows.Forms.Label sigmoidAVLabel;
        private System.Windows.Forms.Label momentumLabel;
        private System.Windows.Forms.Label learningRateLabel;
        private System.Windows.Forms.TextBox learningRateText;
        private System.Windows.Forms.TextBox iterationText;
        private System.Windows.Forms.TextBox momentumText;
        private System.Windows.Forms.TextBox sigmoidAVText;
        private System.Windows.Forms.Button learnButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label randomiseLabel;
        private System.Windows.Forms.CheckBox randomiseCheckBox;
        private System.Windows.Forms.Button testButton;
        private System.Windows.Forms.CheckBox randomMomentumCheckBox;
        private System.Windows.Forms.Button defaultSettingsButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Label correctLabel;
        private System.Windows.Forms.Button reduceErrorButton;
    }
}