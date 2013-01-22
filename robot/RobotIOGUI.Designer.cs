namespace robot
{
    partial class RobotIOGUI
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
            this.voiceToneLabel = new System.Windows.Forms.Label();
            this.voiceToneTextBox = new System.Windows.Forms.TextBox();
            this.proximityTextBox = new System.Windows.Forms.TextBox();
            this.proximityLabel1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.responseTextBox = new System.Windows.Forms.TextBox();
            this.responseLabel = new System.Windows.Forms.Label();
            this.categoryTextBox = new System.Windows.Forms.TextBox();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // voiceToneLabel
            // 
            this.voiceToneLabel.AutoSize = true;
            this.voiceToneLabel.Location = new System.Drawing.Point(21, 31);
            this.voiceToneLabel.Name = "voiceToneLabel";
            this.voiceToneLabel.Size = new System.Drawing.Size(62, 13);
            this.voiceToneLabel.TabIndex = 0;
            this.voiceToneLabel.Text = "Voice Tone";
            this.voiceToneLabel.Click += new System.EventHandler(this.voiceToneLabel_Click);
            // 
            // voiceToneTextBox
            // 
            this.voiceToneTextBox.Location = new System.Drawing.Point(112, 28);
            this.voiceToneTextBox.Name = "voiceToneTextBox";
            this.voiceToneTextBox.Size = new System.Drawing.Size(131, 20);
            this.voiceToneTextBox.TabIndex = 1;
            this.voiceToneTextBox.TextChanged += new System.EventHandler(this.voiceToneTextBox_TextChanged);
            // 
            // proximityTextBox
            // 
            this.proximityTextBox.Location = new System.Drawing.Point(112, 64);
            this.proximityTextBox.Name = "proximityTextBox";
            this.proximityTextBox.Size = new System.Drawing.Size(131, 20);
            this.proximityTextBox.TabIndex = 3;
            this.proximityTextBox.TextChanged += new System.EventHandler(this.proximityTextBox_TextChanged);
            // 
            // proximityLabel1
            // 
            this.proximityLabel1.AutoSize = true;
            this.proximityLabel1.Location = new System.Drawing.Point(21, 67);
            this.proximityLabel1.Name = "proximityLabel1";
            this.proximityLabel1.Size = new System.Drawing.Size(48, 13);
            this.proximityLabel1.TabIndex = 2;
            this.proximityLabel1.Text = "Proximity";
            this.proximityLabel1.Click += new System.EventHandler(this.proximityLabel1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.proximityTextBox);
            this.groupBox1.Controls.Add(this.proximityLabel1);
            this.groupBox1.Controls.Add(this.voiceToneTextBox);
            this.groupBox1.Controls.Add(this.voiceToneLabel);
            this.groupBox1.Location = new System.Drawing.Point(24, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 106);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.responseTextBox);
            this.groupBox2.Controls.Add(this.responseLabel);
            this.groupBox2.Controls.Add(this.categoryTextBox);
            this.groupBox2.Controls.Add(this.categoryLabel);
            this.groupBox2.Location = new System.Drawing.Point(24, 145);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(285, 106);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Output";
            // 
            // responseTextBox
            // 
            this.responseTextBox.Location = new System.Drawing.Point(112, 64);
            this.responseTextBox.Name = "responseTextBox";
            this.responseTextBox.Size = new System.Drawing.Size(131, 20);
            this.responseTextBox.TabIndex = 3;
            // 
            // responseLabel
            // 
            this.responseLabel.AutoSize = true;
            this.responseLabel.Location = new System.Drawing.Point(21, 67);
            this.responseLabel.Name = "responseLabel";
            this.responseLabel.Size = new System.Drawing.Size(55, 13);
            this.responseLabel.TabIndex = 2;
            this.responseLabel.Text = "Response";
            // 
            // categoryTextBox
            // 
            this.categoryTextBox.Location = new System.Drawing.Point(112, 28);
            this.categoryTextBox.Name = "categoryTextBox";
            this.categoryTextBox.Size = new System.Drawing.Size(131, 20);
            this.categoryTextBox.TabIndex = 1;
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Location = new System.Drawing.Point(21, 31);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(49, 13);
            this.categoryLabel.TabIndex = 0;
            this.categoryLabel.Text = "Category";
            // 
            // RobotIOGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(501, 278);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.Red;
            this.Name = "RobotIOGUI";
            this.Text = "Robot Input/Output";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label voiceToneLabel;
        private System.Windows.Forms.TextBox voiceToneTextBox;
        private System.Windows.Forms.TextBox proximityTextBox;
        private System.Windows.Forms.Label proximityLabel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox responseTextBox;
        private System.Windows.Forms.Label responseLabel;
        private System.Windows.Forms.TextBox categoryTextBox;
        private System.Windows.Forms.Label categoryLabel;
    }
}