namespace robot
{
    partial class ControlRobotGUI
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
            this.instructRobotButton = new System.Windows.Forms.Button();
            this.robotActionsListBox = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.visionButton = new System.Windows.Forms.Button();
            this.sonicSesnorButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // instructRobotButton
            // 
            this.instructRobotButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.instructRobotButton.ForeColor = System.Drawing.Color.White;
            this.instructRobotButton.Location = new System.Drawing.Point(167, 71);
            this.instructRobotButton.Name = "instructRobotButton";
            this.instructRobotButton.Size = new System.Drawing.Size(98, 25);
            this.instructRobotButton.TabIndex = 2;
            this.instructRobotButton.Text = "Instruct Robot";
            this.instructRobotButton.UseVisualStyleBackColor = false;
            this.instructRobotButton.Click += new System.EventHandler(this.instructRobotButton_Click);
            // 
            // robotActionsListBox
            // 
            this.robotActionsListBox.FormattingEnabled = true;
            this.robotActionsListBox.Items.AddRange(new object[] {
            "RightArmThrow",
            "LeftArmThrow",
            "RightKick",
            "Laugh",
            "Roar",
            "RightPush",
            "Insult",
            "RightChop",
            "Fetch",
            "LeftChop",
            "Danger",
            "LeftPush",
            "Plan",
            "CalmDown",
            "SpareChange",
            "Hug",
            "DanceDemo",
            "Oops",
            "High5",
            "HeyBaby",
            "Burp",
            "DontPress"});
            this.robotActionsListBox.Location = new System.Drawing.Point(16, 24);
            this.robotActionsListBox.Name = "robotActionsListBox";
            this.robotActionsListBox.Size = new System.Drawing.Size(120, 121);
            this.robotActionsListBox.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.robotActionsListBox);
            this.groupBox1.Controls.Add(this.instructRobotButton);
            this.groupBox1.Location = new System.Drawing.Point(21, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 164);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Control Robot";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.visionButton);
            this.groupBox2.Controls.Add(this.sonicSesnorButton);
            this.groupBox2.Location = new System.Drawing.Point(23, 207);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(305, 127);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Control Sensors";
            // 
            // visionButton
            // 
            this.visionButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.visionButton.ForeColor = System.Drawing.Color.White;
            this.visionButton.Location = new System.Drawing.Point(96, 70);
            this.visionButton.Name = "visionButton";
            this.visionButton.Size = new System.Drawing.Size(136, 25);
            this.visionButton.TabIndex = 4;
            this.visionButton.Text = "Disable Vision Sensors";
            this.visionButton.UseVisualStyleBackColor = false;
            this.visionButton.Click += new System.EventHandler(this.visionButton_Click);
            // 
            // sonicSesnorButton
            // 
            this.sonicSesnorButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.sonicSesnorButton.ForeColor = System.Drawing.Color.White;
            this.sonicSesnorButton.Location = new System.Drawing.Point(96, 28);
            this.sonicSesnorButton.Name = "sonicSesnorButton";
            this.sonicSesnorButton.Size = new System.Drawing.Size(136, 25);
            this.sonicSesnorButton.TabIndex = 3;
            this.sonicSesnorButton.Text = "Disable Sonic Sensors";
            this.sonicSesnorButton.UseVisualStyleBackColor = false;
            this.sonicSesnorButton.Click += new System.EventHandler(this.sonicSensorButton_Click);
            // 
            // ControlRobotGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InfoText;
            this.ClientSize = new System.Drawing.Size(398, 374);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.Red;
            this.Name = "ControlRobotGUI";
            this.Text = "Control Robot";
            this.Load += new System.EventHandler(this.ControlRobotGUI_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button instructRobotButton;
        private System.Windows.Forms.ListBox robotActionsListBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button visionButton;
        private System.Windows.Forms.Button sonicSesnorButton;
    }
}