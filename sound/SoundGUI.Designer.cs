namespace SoundCatcher
{
    partial class SoundGUI
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SoundGUI));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.textBoxConsole = new System.Windows.Forms.TextBox();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.sampleNameTextBox = new System.Windows.Forms.TextBox();
            this.sampleNameLabel = new System.Windows.Forms.Label();
            this.sampleMessageTextLabel = new System.Windows.Forms.Label();
            this.takeSampleButton = new System.Windows.Forms.Button();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.splitContainer6 = new System.Windows.Forms.SplitContainer();
            this.pictureBoxTimeDomainLeft = new System.Windows.Forms.PictureBox();
            this.pictureBoxTimeDomainRight = new System.Windows.Forms.PictureBox();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.neuralOutputlabel = new System.Windows.Forms.Label();
            this.interactLabel = new System.Windows.Forms.Label();
            this.interactButton = new System.Windows.Forms.Button();
            this.learnButton = new System.Windows.Forms.Button();
            this.networkErrorLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.splitContainer5.Panel1.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.splitContainer6.Panel1.SuspendLayout();
            this.splitContainer6.Panel2.SuspendLayout();
            this.splitContainer6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTimeDomainLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTimeDomainRight)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer1.Size = new System.Drawing.Size(664, 386);
            this.splitContainer1.SplitterDistance = 329;
            this.splitContainer1.TabIndex = 1;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.textBoxConsole);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer5);
            this.splitContainer2.Size = new System.Drawing.Size(329, 386);
            this.splitContainer2.SplitterDistance = 186;
            this.splitContainer2.TabIndex = 0;
            // 
            // textBoxConsole
            // 
            this.textBoxConsole.BackColor = System.Drawing.Color.White;
            this.textBoxConsole.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxConsole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxConsole.ForeColor = System.Drawing.Color.Red;
            this.textBoxConsole.Location = new System.Drawing.Point(0, 0);
            this.textBoxConsole.Multiline = true;
            this.textBoxConsole.Name = "textBoxConsole";
            this.textBoxConsole.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxConsole.Size = new System.Drawing.Size(329, 186);
            this.textBoxConsole.TabIndex = 4;
            this.textBoxConsole.TextChanged += new System.EventHandler(this.textBoxConsole_TextChanged);
            // 
            // splitContainer5
            // 
            this.splitContainer5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer5.IsSplitterFixed = true;
            this.splitContainer5.Location = new System.Drawing.Point(0, 0);
            this.splitContainer5.Name = "splitContainer5";
            this.splitContainer5.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer5.Panel1
            // 
            this.splitContainer5.Panel1.BackColor = System.Drawing.SystemColors.ControlText;
            this.splitContainer5.Panel1.Controls.Add(this.sampleNameTextBox);
            this.splitContainer5.Panel1.Controls.Add(this.sampleNameLabel);
            this.splitContainer5.Panel1.Controls.Add(this.sampleMessageTextLabel);
            this.splitContainer5.Panel1.Controls.Add(this.takeSampleButton);
            this.splitContainer5.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer5_Panel1_Paint);
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.BackColor = System.Drawing.Color.Black;
            this.splitContainer5.Panel2.ForeColor = System.Drawing.Color.Red;
            this.splitContainer5.Size = new System.Drawing.Size(329, 196);
            this.splitContainer5.SplitterDistance = 89;
            this.splitContainer5.TabIndex = 7;
            // 
            // sampleNameTextBox
            // 
            this.sampleNameTextBox.Location = new System.Drawing.Point(91, 7);
            this.sampleNameTextBox.Name = "sampleNameTextBox";
            this.sampleNameTextBox.Size = new System.Drawing.Size(114, 20);
            this.sampleNameTextBox.TabIndex = 7;
            // 
            // sampleNameLabel
            // 
            this.sampleNameLabel.AutoSize = true;
            this.sampleNameLabel.Location = new System.Drawing.Point(12, 10);
            this.sampleNameLabel.Name = "sampleNameLabel";
            this.sampleNameLabel.Size = new System.Drawing.Size(73, 13);
            this.sampleNameLabel.TabIndex = 6;
            this.sampleNameLabel.Text = "Sample Name";
            this.sampleNameLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // sampleMessageTextLabel
            // 
            this.sampleMessageTextLabel.Location = new System.Drawing.Point(12, 39);
            this.sampleMessageTextLabel.Name = "sampleMessageTextLabel";
            this.sampleMessageTextLabel.Size = new System.Drawing.Size(200, 13);
            this.sampleMessageTextLabel.TabIndex = 5;
            this.sampleMessageTextLabel.Click += new System.EventHandler(this.sampleMessageTextLabel_Click);
            // 
            // takeSampleButton
            // 
            this.takeSampleButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.takeSampleButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.takeSampleButton.Location = new System.Drawing.Point(221, 3);
            this.takeSampleButton.Name = "takeSampleButton";
            this.takeSampleButton.Size = new System.Drawing.Size(95, 26);
            this.takeSampleButton.TabIndex = 4;
            this.takeSampleButton.Text = "Take Sample";
            this.takeSampleButton.UseVisualStyleBackColor = false;
            this.takeSampleButton.Click += new System.EventHandler(this.takeSampleButton_Click);
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.splitContainer6);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.splitContainer4);
            this.splitContainer3.Size = new System.Drawing.Size(331, 386);
            this.splitContainer3.SplitterDistance = 186;
            this.splitContainer3.TabIndex = 0;
            // 
            // splitContainer6
            // 
            this.splitContainer6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer6.IsSplitterFixed = true;
            this.splitContainer6.Location = new System.Drawing.Point(0, 0);
            this.splitContainer6.Name = "splitContainer6";
            this.splitContainer6.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer6.Panel1
            // 
            this.splitContainer6.Panel1.Controls.Add(this.pictureBoxTimeDomainLeft);
            // 
            // splitContainer6.Panel2
            // 
            this.splitContainer6.Panel2.Controls.Add(this.pictureBoxTimeDomainRight);
            this.splitContainer6.Size = new System.Drawing.Size(331, 186);
            this.splitContainer6.SplitterDistance = 93;
            this.splitContainer6.TabIndex = 7;
            // 
            // pictureBoxTimeDomainLeft
            // 
            this.pictureBoxTimeDomainLeft.BackColor = System.Drawing.Color.White;
            this.pictureBoxTimeDomainLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxTimeDomainLeft.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxTimeDomainLeft.Name = "pictureBoxTimeDomainLeft";
            this.pictureBoxTimeDomainLeft.Size = new System.Drawing.Size(331, 93);
            this.pictureBoxTimeDomainLeft.TabIndex = 3;
            this.pictureBoxTimeDomainLeft.TabStop = false;
            // 
            // pictureBoxTimeDomainRight
            // 
            this.pictureBoxTimeDomainRight.BackColor = System.Drawing.Color.White;
            this.pictureBoxTimeDomainRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxTimeDomainRight.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxTimeDomainRight.Name = "pictureBoxTimeDomainRight";
            this.pictureBoxTimeDomainRight.Size = new System.Drawing.Size(331, 89);
            this.pictureBoxTimeDomainRight.TabIndex = 6;
            this.pictureBoxTimeDomainRight.TabStop = false;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.IsSplitterFixed = true;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.BackColor = System.Drawing.Color.Black;
            this.splitContainer4.Panel1.Controls.Add(this.neuralOutputlabel);
            this.splitContainer4.Panel1.Controls.Add(this.interactLabel);
            this.splitContainer4.Panel1.Controls.Add(this.interactButton);
            this.splitContainer4.Panel1.ForeColor = System.Drawing.Color.Red;
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.BackColor = System.Drawing.Color.Black;
            this.splitContainer4.Panel2.Controls.Add(this.learnButton);
            this.splitContainer4.Panel2.Controls.Add(this.networkErrorLabel);
            this.splitContainer4.Panel2.ForeColor = System.Drawing.Color.Red;
            this.splitContainer4.Size = new System.Drawing.Size(331, 196);
            this.splitContainer4.SplitterDistance = 89;
            this.splitContainer4.TabIndex = 6;
            // 
            // neuralOutputlabel
            // 
            this.neuralOutputlabel.Location = new System.Drawing.Point(119, 48);
            this.neuralOutputlabel.Name = "neuralOutputlabel";
            this.neuralOutputlabel.Size = new System.Drawing.Size(200, 13);
            this.neuralOutputlabel.TabIndex = 10;
            // 
            // interactLabel
            // 
            this.interactLabel.Location = new System.Drawing.Point(119, 10);
            this.interactLabel.Name = "interactLabel";
            this.interactLabel.Size = new System.Drawing.Size(200, 13);
            this.interactLabel.TabIndex = 9;
            // 
            // interactButton
            // 
            this.interactButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.interactButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.interactButton.Location = new System.Drawing.Point(18, 3);
            this.interactButton.Name = "interactButton";
            this.interactButton.Size = new System.Drawing.Size(95, 26);
            this.interactButton.TabIndex = 8;
            this.interactButton.Text = "Interact";
            this.interactButton.UseVisualStyleBackColor = false;
            this.interactButton.Click += new System.EventHandler(this.interactButton_Click);
            // 
            // learnButton
            // 
            this.learnButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.learnButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.learnButton.Location = new System.Drawing.Point(25, 48);
            this.learnButton.Name = "learnButton";
            this.learnButton.Size = new System.Drawing.Size(106, 30);
            this.learnButton.TabIndex = 1;
            this.learnButton.Text = "Reduce Error";
            this.learnButton.UseVisualStyleBackColor = false;
            this.learnButton.Click += new System.EventHandler(this.learnButton_Click);
            // 
            // networkErrorLabel
            // 
            this.networkErrorLabel.AutoSize = true;
            this.networkErrorLabel.Location = new System.Drawing.Point(25, 22);
            this.networkErrorLabel.Name = "networkErrorLabel";
            this.networkErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.networkErrorLabel.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlText;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(664, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.settingsToolStripMenuItem.Text = "&Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.optionsToolStripMenuItem.Text = "&Options";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 420);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(664, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "SoundCatcher";
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // SoundGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 442);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SoundGUI";
            this.Text = "SoundCatcher";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.SizeChanged += new System.EventHandler(this.FormMain_SizeChanged);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer5.Panel1.ResumeLayout(false);
            this.splitContainer5.Panel1.PerformLayout();
            this.splitContainer5.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer6.Panel1.ResumeLayout(false);
            this.splitContainer6.Panel2.ResumeLayout(false);
            this.splitContainer6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTimeDomainLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTimeDomainRight)).EndInit();
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            this.splitContainer4.Panel2.PerformLayout();
            this.splitContainer4.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TextBox textBoxConsole;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.SplitContainer splitContainer5;
        private System.Windows.Forms.SplitContainer splitContainer6;
        private System.Windows.Forms.PictureBox pictureBoxTimeDomainLeft;
        private System.Windows.Forms.PictureBox pictureBoxTimeDomainRight;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button takeSampleButton;
        private System.Windows.Forms.Label sampleNameLabel;
        private System.Windows.Forms.Label sampleMessageTextLabel;
        private System.Windows.Forms.TextBox sampleNameTextBox;
        private System.Windows.Forms.Label interactLabel;
        private System.Windows.Forms.Button interactButton;
        private System.Windows.Forms.Label neuralOutputlabel;
        private System.Windows.Forms.Button learnButton;
        private System.Windows.Forms.Label networkErrorLabel;


    }
}

