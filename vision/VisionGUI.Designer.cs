using WebCam_Capture;

namespace vision
{
    partial class VisionGUI
    {
        private System.Windows.Forms.PictureBox currentImage;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button continueButton;
        private WebCam_Capture.WebCamCapture capture;

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
            this.currentImage = new System.Windows.Forms.PictureBox();
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.continueButton = new System.Windows.Forms.Button();
            this.motionImage = new System.Windows.Forms.PictureBox();
            this.colordetectionImage = new System.Windows.Forms.PictureBox();
            this.modelImage = new System.Windows.Forms.PictureBox();
            this.distanceLabel = new System.Windows.Forms.Label();
            this.approachingDetractingLabel = new System.Windows.Forms.Label();
            this.handDistanceLabel = new System.Windows.Forms.Label();
            this.motionLevel = new System.Windows.Forms.Label();
            this.proxmityTextField = new System.Windows.Forms.TextBox();
            this.approachingDetractingTextField = new System.Windows.Forms.TextBox();
            this.handGestureTextField = new System.Windows.Forms.TextBox();
            this.motionLevelTextField = new System.Windows.Forms.TextBox();
            this.currentFrameLabel = new System.Windows.Forms.Label();
            this.motionDetectionLabel = new System.Windows.Forms.Label();
            this.colourDetectionLabel = new System.Windows.Forms.Label();
            this.modelLabel = new System.Windows.Forms.Label();
            this.currentFrameCheckBox = new System.Windows.Forms.CheckBox();
            this.motionDetectionCheckBox = new System.Windows.Forms.CheckBox();
            this.colorDetectionCheckBox = new System.Windows.Forms.CheckBox();
            this.modelCheckBox = new System.Windows.Forms.CheckBox();
            this.interactionTimeLabel = new System.Windows.Forms.Label();
            this.interactButton = new System.Windows.Forms.Button();
            this.waitTimeLabel = new System.Windows.Forms.Label();
            this.waitingTimeText = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.capture = new WebCam_Capture.WebCamCapture();
            ((System.ComponentModel.ISupportInitialize)(this.currentImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.motionImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colordetectionImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelImage)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // currentImage
            // 
            this.currentImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.currentImage.Location = new System.Drawing.Point(377, 45);
            this.currentImage.Name = "currentImage";
            this.currentImage.Size = new System.Drawing.Size(320, 240);
            this.currentImage.TabIndex = 1;
            this.currentImage.TabStop = false;
            this.currentImage.Click += new System.EventHandler(this.image1_Click);
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.startButton.Location = new System.Drawing.Point(24, 21);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(145, 34);
            this.startButton.TabIndex = 2;
            this.startButton.Text = "START";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.stopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.stopButton.Location = new System.Drawing.Point(24, 76);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(145, 34);
            this.stopButton.TabIndex = 3;
            this.stopButton.Text = "STOP";
            this.stopButton.UseVisualStyleBackColor = false;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // continueButton
            // 
            this.continueButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.continueButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.continueButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.continueButton.Location = new System.Drawing.Point(24, 128);
            this.continueButton.Name = "continueButton";
            this.continueButton.Size = new System.Drawing.Size(145, 34);
            this.continueButton.TabIndex = 4;
            this.continueButton.Text = "CONTINUE";
            this.continueButton.UseVisualStyleBackColor = false;
            this.continueButton.Click += new System.EventHandler(this.continueButton_Click);
            // 
            // motionImage
            // 
            this.motionImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.motionImage.Location = new System.Drawing.Point(721, 45);
            this.motionImage.Name = "motionImage";
            this.motionImage.Size = new System.Drawing.Size(320, 240);
            this.motionImage.TabIndex = 5;
            this.motionImage.TabStop = false;
            // 
            // colordetectionImage
            // 
            this.colordetectionImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.colordetectionImage.Location = new System.Drawing.Point(377, 333);
            this.colordetectionImage.Name = "colordetectionImage";
            this.colordetectionImage.Size = new System.Drawing.Size(320, 240);
            this.colordetectionImage.TabIndex = 6;
            this.colordetectionImage.TabStop = false;
            // 
            // modelImage
            // 
            this.modelImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.modelImage.Location = new System.Drawing.Point(721, 333);
            this.modelImage.Name = "modelImage";
            this.modelImage.Size = new System.Drawing.Size(320, 240);
            this.modelImage.TabIndex = 7;
            this.modelImage.TabStop = false;
            // 
            // distanceLabel
            // 
            this.distanceLabel.AutoSize = true;
            this.distanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.distanceLabel.Location = new System.Drawing.Point(33, 18);
            this.distanceLabel.Name = "distanceLabel";
            this.distanceLabel.Size = new System.Drawing.Size(48, 13);
            this.distanceLabel.TabIndex = 8;
            this.distanceLabel.Text = "Proximity";
            this.distanceLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // approachingDetractingLabel
            // 
            this.approachingDetractingLabel.AutoSize = true;
            this.approachingDetractingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.approachingDetractingLabel.Location = new System.Drawing.Point(33, 52);
            this.approachingDetractingLabel.Name = "approachingDetractingLabel";
            this.approachingDetractingLabel.Size = new System.Drawing.Size(131, 13);
            this.approachingDetractingLabel.TabIndex = 9;
            this.approachingDetractingLabel.Text = "Approaching Or detracting";
            // 
            // handDistanceLabel
            // 
            this.handDistanceLabel.AutoSize = true;
            this.handDistanceLabel.Location = new System.Drawing.Point(33, 83);
            this.handDistanceLabel.Name = "handDistanceLabel";
            this.handDistanceLabel.Size = new System.Drawing.Size(73, 13);
            this.handDistanceLabel.TabIndex = 10;
            this.handDistanceLabel.Text = "Hand Gesture";
            this.handDistanceLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // motionLevel
            // 
            this.motionLevel.AutoSize = true;
            this.motionLevel.Location = new System.Drawing.Point(33, 119);
            this.motionLevel.Name = "motionLevel";
            this.motionLevel.Size = new System.Drawing.Size(68, 13);
            this.motionLevel.TabIndex = 11;
            this.motionLevel.Text = "Motion Level";
            // 
            // proxmityTextField
            // 
            this.proxmityTextField.Location = new System.Drawing.Point(183, 14);
            this.proxmityTextField.Margin = new System.Windows.Forms.Padding(2);
            this.proxmityTextField.Name = "proxmityTextField";
            this.proxmityTextField.Size = new System.Drawing.Size(128, 20);
            this.proxmityTextField.TabIndex = 12;
            this.proxmityTextField.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // approachingDetractingTextField
            // 
            this.approachingDetractingTextField.Location = new System.Drawing.Point(183, 48);
            this.approachingDetractingTextField.Margin = new System.Windows.Forms.Padding(2);
            this.approachingDetractingTextField.Name = "approachingDetractingTextField";
            this.approachingDetractingTextField.Size = new System.Drawing.Size(128, 20);
            this.approachingDetractingTextField.TabIndex = 13;
            // 
            // handGestureTextField
            // 
            this.handGestureTextField.Location = new System.Drawing.Point(183, 83);
            this.handGestureTextField.Margin = new System.Windows.Forms.Padding(2);
            this.handGestureTextField.Name = "handGestureTextField";
            this.handGestureTextField.Size = new System.Drawing.Size(128, 20);
            this.handGestureTextField.TabIndex = 14;
            // 
            // motionLevelTextField
            // 
            this.motionLevelTextField.Location = new System.Drawing.Point(183, 119);
            this.motionLevelTextField.Margin = new System.Windows.Forms.Padding(2);
            this.motionLevelTextField.Name = "motionLevelTextField";
            this.motionLevelTextField.Size = new System.Drawing.Size(128, 20);
            this.motionLevelTextField.TabIndex = 15;
            // 
            // currentFrameLabel
            // 
            this.currentFrameLabel.AutoSize = true;
            this.currentFrameLabel.Location = new System.Drawing.Point(374, 19);
            this.currentFrameLabel.Name = "currentFrameLabel";
            this.currentFrameLabel.Size = new System.Drawing.Size(73, 13);
            this.currentFrameLabel.TabIndex = 16;
            this.currentFrameLabel.Text = "Current Frame";
            this.currentFrameLabel.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // motionDetectionLabel
            // 
            this.motionDetectionLabel.AutoSize = true;
            this.motionDetectionLabel.Location = new System.Drawing.Point(718, 19);
            this.motionDetectionLabel.Name = "motionDetectionLabel";
            this.motionDetectionLabel.Size = new System.Drawing.Size(88, 13);
            this.motionDetectionLabel.TabIndex = 17;
            this.motionDetectionLabel.Text = "Motion Detection";
            // 
            // colourDetectionLabel
            // 
            this.colourDetectionLabel.AutoSize = true;
            this.colourDetectionLabel.Location = new System.Drawing.Point(374, 301);
            this.colourDetectionLabel.Name = "colourDetectionLabel";
            this.colourDetectionLabel.Size = new System.Drawing.Size(86, 13);
            this.colourDetectionLabel.TabIndex = 18;
            this.colourDetectionLabel.Text = "Colour Detection";
            this.colourDetectionLabel.Click += new System.EventHandler(this.label1_Click_3);
            // 
            // modelLabel
            // 
            this.modelLabel.AutoSize = true;
            this.modelLabel.Location = new System.Drawing.Point(718, 301);
            this.modelLabel.Name = "modelLabel";
            this.modelLabel.Size = new System.Drawing.Size(36, 13);
            this.modelLabel.TabIndex = 19;
            this.modelLabel.Text = "Model";
            // 
            // currentFrameCheckBox
            // 
            this.currentFrameCheckBox.AutoSize = true;
            this.currentFrameCheckBox.Checked = true;
            this.currentFrameCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.currentFrameCheckBox.Location = new System.Drawing.Point(453, 19);
            this.currentFrameCheckBox.Name = "currentFrameCheckBox";
            this.currentFrameCheckBox.Size = new System.Drawing.Size(53, 17);
            this.currentFrameCheckBox.TabIndex = 20;
            this.currentFrameCheckBox.Text = "Show";
            this.currentFrameCheckBox.UseVisualStyleBackColor = true;
            // 
            // motionDetectionCheckBox
            // 
            this.motionDetectionCheckBox.AutoSize = true;
            this.motionDetectionCheckBox.Checked = true;
            this.motionDetectionCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.motionDetectionCheckBox.Location = new System.Drawing.Point(812, 19);
            this.motionDetectionCheckBox.Name = "motionDetectionCheckBox";
            this.motionDetectionCheckBox.Size = new System.Drawing.Size(53, 17);
            this.motionDetectionCheckBox.TabIndex = 21;
            this.motionDetectionCheckBox.Text = "Show";
            this.motionDetectionCheckBox.UseVisualStyleBackColor = true;
            // 
            // colorDetectionCheckBox
            // 
            this.colorDetectionCheckBox.AutoSize = true;
            this.colorDetectionCheckBox.Checked = true;
            this.colorDetectionCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.colorDetectionCheckBox.Location = new System.Drawing.Point(466, 300);
            this.colorDetectionCheckBox.Name = "colorDetectionCheckBox";
            this.colorDetectionCheckBox.Size = new System.Drawing.Size(53, 17);
            this.colorDetectionCheckBox.TabIndex = 22;
            this.colorDetectionCheckBox.Text = "Show";
            this.colorDetectionCheckBox.UseVisualStyleBackColor = true;
            // 
            // modelCheckBox
            // 
            this.modelCheckBox.AutoSize = true;
            this.modelCheckBox.Checked = true;
            this.modelCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.modelCheckBox.Location = new System.Drawing.Point(760, 300);
            this.modelCheckBox.Name = "modelCheckBox";
            this.modelCheckBox.Size = new System.Drawing.Size(53, 17);
            this.modelCheckBox.TabIndex = 23;
            this.modelCheckBox.Text = "Show";
            this.modelCheckBox.UseVisualStyleBackColor = true;
            // 
            // interactionTimeLabel
            // 
            this.interactionTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.interactionTimeLabel.Location = new System.Drawing.Point(19, 99);
            this.interactionTimeLabel.Name = "interactionTimeLabel";
            this.interactionTimeLabel.Size = new System.Drawing.Size(279, 35);
            this.interactionTimeLabel.TabIndex = 300;
            this.interactionTimeLabel.Click += new System.EventHandler(this.interactionTimeLabel_Click);
            // 
            // interactButton
            // 
            this.interactButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.interactButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.interactButton.Location = new System.Drawing.Point(23, 27);
            this.interactButton.Name = "interactButton";
            this.interactButton.Size = new System.Drawing.Size(148, 28);
            this.interactButton.TabIndex = 25;
            this.interactButton.Text = "Interact";
            this.interactButton.UseVisualStyleBackColor = false;
            this.interactButton.Click += new System.EventHandler(this.interactButton_Click);
            // 
            // waitTimeLabel
            // 
            this.waitTimeLabel.AutoSize = true;
            this.waitTimeLabel.Location = new System.Drawing.Point(20, 70);
            this.waitTimeLabel.Name = "waitTimeLabel";
            this.waitTimeLabel.Size = new System.Drawing.Size(108, 13);
            this.waitTimeLabel.TabIndex = 26;
            this.waitTimeLabel.Text = "Interaction Wait Time";
            this.waitTimeLabel.Click += new System.EventHandler(this.waitTimeLabel_Click);
            // 
            // waitingTimeText
            // 
            this.waitingTimeText.Location = new System.Drawing.Point(134, 67);
            this.waitingTimeText.Name = "waitingTimeText";
            this.waitingTimeText.Size = new System.Drawing.Size(35, 20);
            this.waitingTimeText.TabIndex = 27;
            this.waitingTimeText.Text = "5";
            this.waitingTimeText.TextChanged += new System.EventHandler(this.waitingTimeText_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.continueButton);
            this.groupBox1.Controls.Add(this.stopButton);
            this.groupBox1.Controls.Add(this.startButton);
            this.groupBox1.Location = new System.Drawing.Point(25, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 207);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Controls";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.motionLevelTextField);
            this.groupBox2.Controls.Add(this.handGestureTextField);
            this.groupBox2.Controls.Add(this.approachingDetractingTextField);
            this.groupBox2.Controls.Add(this.proxmityTextField);
            this.groupBox2.Controls.Add(this.motionLevel);
            this.groupBox2.Controls.Add(this.handDistanceLabel);
            this.groupBox2.Controls.Add(this.approachingDetractingLabel);
            this.groupBox2.Controls.Add(this.distanceLabel);
            this.groupBox2.Location = new System.Drawing.Point(20, 429);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(331, 160);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Analysis";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.waitingTimeText);
            this.groupBox3.Controls.Add(this.waitTimeLabel);
            this.groupBox3.Controls.Add(this.interactButton);
            this.groupBox3.Controls.Add(this.interactionTimeLabel);
            this.groupBox3.Location = new System.Drawing.Point(25, 277);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(326, 146);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Interaction";
            // 
            // capture
            // 
            this.capture.CaptureHeight = 240;
            this.capture.CaptureWidth = 320;
            this.capture.FrameNumber = ((ulong)(0ul));
            this.capture.Location = new System.Drawing.Point(17, 17);
            this.capture.Name = "WebCamCapture";
            this.capture.Size = new System.Drawing.Size(342, 252);
            this.capture.TabIndex = 0;
            this.capture.TimeToCapture_milliseconds = 100;
            this.capture.ImageCaptured += new WebCam_Capture.WebCamCapture.WebCamEventHandler(this.WebCamCapture_ImageCaptured);
            // 
            // VisionGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1050, 601);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.modelCheckBox);
            this.Controls.Add(this.colorDetectionCheckBox);
            this.Controls.Add(this.motionDetectionCheckBox);
            this.Controls.Add(this.currentFrameCheckBox);
            this.Controls.Add(this.modelLabel);
            this.Controls.Add(this.colourDetectionLabel);
            this.Controls.Add(this.motionDetectionLabel);
            this.Controls.Add(this.currentFrameLabel);
            this.Controls.Add(this.modelImage);
            this.Controls.Add(this.colordetectionImage);
            this.Controls.Add(this.motionImage);
            this.Controls.Add(this.currentImage);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Red;
            this.Name = "VisionGUI";
            this.Text = "Vision System ";
            this.Load += new System.EventHandler(this.mainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.currentImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.motionImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colordetectionImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelImage)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox motionImage;
        private System.Windows.Forms.PictureBox colordetectionImage;
        private System.Windows.Forms.PictureBox modelImage;
        private System.Windows.Forms.Label distanceLabel;
        private System.Windows.Forms.Label approachingDetractingLabel;
        private System.Windows.Forms.Label handDistanceLabel;
        private System.Windows.Forms.Label motionLevel;
        private System.Windows.Forms.TextBox proxmityTextField;
        private System.Windows.Forms.TextBox approachingDetractingTextField;
        private System.Windows.Forms.TextBox handGestureTextField;
        private System.Windows.Forms.TextBox motionLevelTextField;
        private System.Windows.Forms.Label currentFrameLabel;
        private System.Windows.Forms.Label motionDetectionLabel;
        private System.Windows.Forms.Label colourDetectionLabel;
        private System.Windows.Forms.Label modelLabel;
        private System.Windows.Forms.CheckBox currentFrameCheckBox;
        private System.Windows.Forms.CheckBox motionDetectionCheckBox;
        private System.Windows.Forms.CheckBox colorDetectionCheckBox;
        private System.Windows.Forms.CheckBox modelCheckBox;
        private System.Windows.Forms.Label interactionTimeLabel;
        private System.Windows.Forms.Button interactButton;
        private System.Windows.Forms.Label waitTimeLabel;
        private System.Windows.Forms.TextBox waitingTimeText;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;

    }
}