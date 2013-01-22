namespace interaction
{
    partial class MainMenuGUI
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
            this.bayesianNetworkButton = new System.Windows.Forms.Button();
            this.neuralNetworkButton = new System.Windows.Forms.Button();
            this.soundSystemButton = new System.Windows.Forms.Button();
            this.visionSystemButton = new System.Windows.Forms.Button();
            this.interactionModeButton1 = new System.Windows.Forms.Button();
            this.controlRobotButton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bayesianNetworkButton
            // 
            this.bayesianNetworkButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.bayesianNetworkButton.ForeColor = System.Drawing.SystemColors.Window;
            this.bayesianNetworkButton.Location = new System.Drawing.Point(93, 232);
            this.bayesianNetworkButton.Name = "bayesianNetworkButton";
            this.bayesianNetworkButton.Size = new System.Drawing.Size(115, 24);
            this.bayesianNetworkButton.TabIndex = 11;
            this.bayesianNetworkButton.Text = "Bayesian Network";
            this.bayesianNetworkButton.UseVisualStyleBackColor = false;
            this.bayesianNetworkButton.Click += new System.EventHandler(this.bayesianNetworkButton_Click);
            // 
            // neuralNetworkButton
            // 
            this.neuralNetworkButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.neuralNetworkButton.ForeColor = System.Drawing.SystemColors.Window;
            this.neuralNetworkButton.Location = new System.Drawing.Point(93, 193);
            this.neuralNetworkButton.Name = "neuralNetworkButton";
            this.neuralNetworkButton.Size = new System.Drawing.Size(115, 24);
            this.neuralNetworkButton.TabIndex = 10;
            this.neuralNetworkButton.Text = "Neural Network";
            this.neuralNetworkButton.UseVisualStyleBackColor = false;
            this.neuralNetworkButton.Click += new System.EventHandler(this.neuralNetworkButton_Click);
            // 
            // soundSystemButton
            // 
            this.soundSystemButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.soundSystemButton.ForeColor = System.Drawing.SystemColors.Window;
            this.soundSystemButton.Location = new System.Drawing.Point(93, 152);
            this.soundSystemButton.Name = "soundSystemButton";
            this.soundSystemButton.Size = new System.Drawing.Size(115, 24);
            this.soundSystemButton.TabIndex = 9;
            this.soundSystemButton.Text = "Sound System";
            this.soundSystemButton.UseVisualStyleBackColor = false;
            this.soundSystemButton.Click += new System.EventHandler(this.soundSystemButton_Click);
            // 
            // visionSystemButton
            // 
            this.visionSystemButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.visionSystemButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.visionSystemButton.ForeColor = System.Drawing.SystemColors.Window;
            this.visionSystemButton.Location = new System.Drawing.Point(93, 113);
            this.visionSystemButton.Name = "visionSystemButton";
            this.visionSystemButton.Size = new System.Drawing.Size(115, 24);
            this.visionSystemButton.TabIndex = 8;
            this.visionSystemButton.Text = "Vision System";
            this.visionSystemButton.UseVisualStyleBackColor = false;
            this.visionSystemButton.Click += new System.EventHandler(this.visionSystemButton_Click);
            // 
            // interactionModeButton1
            // 
            this.interactionModeButton1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.interactionModeButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.interactionModeButton1.ForeColor = System.Drawing.SystemColors.Window;
            this.interactionModeButton1.Location = new System.Drawing.Point(93, 74);
            this.interactionModeButton1.Name = "interactionModeButton1";
            this.interactionModeButton1.Size = new System.Drawing.Size(115, 24);
            this.interactionModeButton1.TabIndex = 7;
            this.interactionModeButton1.Text = "Interaction Mode";
            this.interactionModeButton1.UseVisualStyleBackColor = false;
            this.interactionModeButton1.Click += new System.EventHandler(this.interactionModeButton1_Click);
            // 
            // controlRobotButton
            // 
            this.controlRobotButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.controlRobotButton.ForeColor = System.Drawing.SystemColors.Window;
            this.controlRobotButton.Location = new System.Drawing.Point(93, 272);
            this.controlRobotButton.Name = "controlRobotButton";
            this.controlRobotButton.Size = new System.Drawing.Size(115, 24);
            this.controlRobotButton.TabIndex = 12;
            this.controlRobotButton.Text = "Control Robot";
            this.controlRobotButton.UseVisualStyleBackColor = false;
            this.controlRobotButton.Click += new System.EventHandler(this.controlRobotButton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::interaction.Properties.Resources.robosapien_2;
            this.pictureBox2.Location = new System.Drawing.Point(226, 69);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(214, 254);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::interaction.Properties.Resources.title;
            this.pictureBox1.Location = new System.Drawing.Point(17, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(432, 49);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.controlRobotButton);
            this.panel1.Controls.Add(this.bayesianNetworkButton);
            this.panel1.Controls.Add(this.neuralNetworkButton);
            this.panel1.Controls.Add(this.soundSystemButton);
            this.panel1.Controls.Add(this.visionSystemButton);
            this.panel1.Controls.Add(this.interactionModeButton1);
            this.panel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(467, 393);
            this.panel1.TabIndex = 15;
            // 
            // MainMenuGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(462, 390);
            this.Controls.Add(this.panel1);
            this.Name = "MainMenuGUI";
            this.Text = "Main Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bayesianNetworkButton;
        private System.Windows.Forms.Button neuralNetworkButton;
        private System.Windows.Forms.Button soundSystemButton;
        private System.Windows.Forms.Button visionSystemButton;
        private System.Windows.Forms.Button interactionModeButton1;
        private System.Windows.Forms.Button controlRobotButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
    }
}