namespace SoundCard
{
    partial class FormMain
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPagePlay = new System.Windows.Forms.TabPage();
            this.labelSplitter = new System.Windows.Forms.Label();
            this.buttonPauseResume = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.comboBoxPlayingMethod = new System.Windows.Forms.ComboBox();
            this.labelPlayingMethod = new System.Windows.Forms.Label();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.labelFilename = new System.Windows.Forms.Label();
            this.labelFile = new System.Windows.Forms.Label();
            this.tabPageRecord = new System.Windows.Forms.TabPage();
            this.labelRecording = new System.Windows.Forms.Label();
            this.comboBoxRecordingMethod = new System.Windows.Forms.ComboBox();
            this.labelRecordingMethod = new System.Windows.Forms.Label();
            this.buttonRecord = new System.Windows.Forms.Button();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabPagePlay.SuspendLayout();
            this.tabPageRecord.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPagePlay);
            this.tabControl.Controls.Add(this.tabPageRecord);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(522, 235);
            this.tabControl.TabIndex = 0;
            // 
            // tabPagePlay
            // 
            this.tabPagePlay.Controls.Add(this.label1);
            this.tabPagePlay.Controls.Add(this.labelSplitter);
            this.tabPagePlay.Controls.Add(this.buttonPauseResume);
            this.tabPagePlay.Controls.Add(this.buttonStop);
            this.tabPagePlay.Controls.Add(this.buttonStart);
            this.tabPagePlay.Controls.Add(this.comboBoxPlayingMethod);
            this.tabPagePlay.Controls.Add(this.labelPlayingMethod);
            this.tabPagePlay.Controls.Add(this.buttonOpen);
            this.tabPagePlay.Controls.Add(this.labelFilename);
            this.tabPagePlay.Controls.Add(this.labelFile);
            this.tabPagePlay.Location = new System.Drawing.Point(4, 29);
            this.tabPagePlay.Margin = new System.Windows.Forms.Padding(0);
            this.tabPagePlay.Name = "tabPagePlay";
            this.tabPagePlay.Size = new System.Drawing.Size(514, 202);
            this.tabPagePlay.TabIndex = 0;
            this.tabPagePlay.Text = "Playing";
            this.tabPagePlay.UseVisualStyleBackColor = true;
            // 
            // labelSplitter
            // 
            this.labelSplitter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelSplitter.Location = new System.Drawing.Point(10, 58);
            this.labelSplitter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSplitter.Name = "labelSplitter";
            this.labelSplitter.Size = new System.Drawing.Size(310, 2);
            this.labelSplitter.TabIndex = 8;
            // 
            // buttonPauseResume
            // 
            this.buttonPauseResume.Location = new System.Drawing.Point(116, 134);
            this.buttonPauseResume.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonPauseResume.Name = "buttonPauseResume";
            this.buttonPauseResume.Size = new System.Drawing.Size(100, 35);
            this.buttonPauseResume.TabIndex = 7;
            this.buttonPauseResume.Text = "Pause";
            this.buttonPauseResume.UseVisualStyleBackColor = true;
            this.buttonPauseResume.Click += new System.EventHandler(this.buttonPauseResume_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(222, 134);
            this.buttonStop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(100, 35);
            this.buttonStop.TabIndex = 6;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(10, 134);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(100, 35);
            this.buttonStart.TabIndex = 5;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // comboBoxPlayingMethod
            // 
            this.comboBoxPlayingMethod.FormattingEnabled = true;
            this.comboBoxPlayingMethod.Location = new System.Drawing.Point(10, 92);
            this.comboBoxPlayingMethod.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxPlayingMethod.Name = "comboBoxPlayingMethod";
            this.comboBoxPlayingMethod.Size = new System.Drawing.Size(310, 28);
            this.comboBoxPlayingMethod.TabIndex = 4;
            this.comboBoxPlayingMethod.SelectedIndexChanged += new System.EventHandler(this.comboBoxMethod_SelectedIndexChanged);
            // 
            // labelPlayingMethod
            // 
            this.labelPlayingMethod.AutoSize = true;
            this.labelPlayingMethod.Location = new System.Drawing.Point(6, 68);
            this.labelPlayingMethod.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPlayingMethod.Name = "labelPlayingMethod";
            this.labelPlayingMethod.Size = new System.Drawing.Size(67, 20);
            this.labelPlayingMethod.TabIndex = 3;
            this.labelPlayingMethod.Text = "Method:";
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(210, 8);
            this.buttonOpen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(112, 35);
            this.buttonOpen.TabIndex = 2;
            this.buttonOpen.Text = "Open";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // labelFilename
            // 
            this.labelFilename.AutoEllipsis = true;
            this.labelFilename.Location = new System.Drawing.Point(91, 15);
            this.labelFilename.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFilename.Name = "labelFilename";
            this.labelFilename.Size = new System.Drawing.Size(109, 20);
            this.labelFilename.TabIndex = 1;
            // 
            // labelFile
            // 
            this.labelFile.AutoSize = true;
            this.labelFile.Location = new System.Drawing.Point(6, 15);
            this.labelFile.Name = "labelFile";
            this.labelFile.Size = new System.Drawing.Size(78, 20);
            this.labelFile.TabIndex = 0;
            this.labelFile.Text = "Filename:";
            // 
            // tabPageRecord
            // 
            this.tabPageRecord.Controls.Add(this.labelRecording);
            this.tabPageRecord.Controls.Add(this.comboBoxRecordingMethod);
            this.tabPageRecord.Controls.Add(this.labelRecordingMethod);
            this.tabPageRecord.Controls.Add(this.buttonRecord);
            this.tabPageRecord.Location = new System.Drawing.Point(4, 29);
            this.tabPageRecord.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageRecord.Name = "tabPageRecord";
            this.tabPageRecord.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageRecord.Size = new System.Drawing.Size(338, 202);
            this.tabPageRecord.TabIndex = 1;
            this.tabPageRecord.Text = "Recording";
            this.tabPageRecord.UseVisualStyleBackColor = true;
            // 
            // labelRecording
            // 
            this.labelRecording.AutoSize = true;
            this.labelRecording.Location = new System.Drawing.Point(117, 162);
            this.labelRecording.Name = "labelRecording";
            this.labelRecording.Size = new System.Drawing.Size(108, 20);
            this.labelRecording.TabIndex = 3;
            this.labelRecording.Text = "RECORDING";
            this.labelRecording.Click += new System.EventHandler(this.labelRecording_Click);
            // 
            // comboBoxRecordingMethod
            // 
            this.comboBoxRecordingMethod.FormattingEnabled = true;
            this.comboBoxRecordingMethod.Location = new System.Drawing.Point(84, 12);
            this.comboBoxRecordingMethod.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxRecordingMethod.Name = "comboBoxRecordingMethod";
            this.comboBoxRecordingMethod.Size = new System.Drawing.Size(238, 28);
            this.comboBoxRecordingMethod.TabIndex = 2;
            this.comboBoxRecordingMethod.SelectedIndexChanged += new System.EventHandler(this.comboBoxRecordingMethod_SelectedIndexChanged);
            // 
            // labelRecordingMethod
            // 
            this.labelRecordingMethod.AutoSize = true;
            this.labelRecordingMethod.Location = new System.Drawing.Point(10, 16);
            this.labelRecordingMethod.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRecordingMethod.Name = "labelRecordingMethod";
            this.labelRecordingMethod.Size = new System.Drawing.Size(67, 20);
            this.labelRecordingMethod.TabIndex = 1;
            this.labelRecordingMethod.Text = "Method:";
            // 
            // buttonRecord
            // 
            this.buttonRecord.Location = new System.Drawing.Point(14, 84);
            this.buttonRecord.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonRecord.Name = "buttonRecord";
            this.buttonRecord.Size = new System.Drawing.Size(309, 61);
            this.buttonRecord.TabIndex = 0;
            this.buttonRecord.Text = "Record";
            this.buttonRecord.UseVisualStyleBackColor = true;
            this.buttonRecord.Click += new System.EventHandler(this.buttonRecord_Click);
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(417, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 235);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormMain";
            this.Text = "Sound Card";
            this.tabControl.ResumeLayout(false);
            this.tabPagePlay.ResumeLayout(false);
            this.tabPagePlay.PerformLayout();
            this.tabPageRecord.ResumeLayout(false);
            this.tabPageRecord.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPagePlay;
        private System.Windows.Forms.TabPage tabPageRecord;
        private System.Windows.Forms.Label labelFile;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Label labelFilename;
        private System.Windows.Forms.Button buttonPauseResume;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.ComboBox comboBoxPlayingMethod;
        private System.Windows.Forms.Label labelPlayingMethod;
        private System.Windows.Forms.Label labelSplitter;
        private System.Windows.Forms.Button buttonRecord;
        private System.Windows.Forms.Label labelRecordingMethod;
        private System.Windows.Forms.ComboBox comboBoxRecordingMethod;
        private System.Windows.Forms.Label labelRecording;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.Label label1;
    }
}

