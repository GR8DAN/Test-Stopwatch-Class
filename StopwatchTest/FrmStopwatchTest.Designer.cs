namespace StopwatchTest
{
    partial class FrmStopwatchTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStopwatchTest));
            this.LstStatus = new System.Windows.Forms.ListBox();
            this.ButStart = new System.Windows.Forms.Button();
            this.ButStop = new System.Windows.Forms.Button();
            this.LblStopwatchInfo = new System.Windows.Forms.Label();
            this.ButRead = new System.Windows.Forms.Button();
            this.ButReadMilli = new System.Windows.Forms.Button();
            this.ButReadTicks = new System.Windows.Forms.Button();
            this.ButReset = new System.Windows.Forms.Button();
            this.ButRestart = new System.Windows.Forms.Button();
            this.ButClear = new System.Windows.Forms.Button();
            this.GrpBackground = new System.Windows.Forms.GroupBox();
            this.RdoToggle = new System.Windows.Forms.RadioButton();
            this.LblMilliseconds = new System.Windows.Forms.Label();
            this.TxtTickTime = new System.Windows.Forms.TextBox();
            this.ButTicker = new System.Windows.Forms.Button();
            this.BgrdWorker = new System.ComponentModel.BackgroundWorker();
            this.GrpBackground.SuspendLayout();
            this.SuspendLayout();
            // 
            // LstStatus
            // 
            this.LstStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LstStatus.FormattingEnabled = true;
            this.LstStatus.ItemHeight = 20;
            this.LstStatus.Location = new System.Drawing.Point(12, 149);
            this.LstStatus.Name = "LstStatus";
            this.LstStatus.Size = new System.Drawing.Size(609, 224);
            this.LstStatus.TabIndex = 8;
            // 
            // ButStart
            // 
            this.ButStart.Location = new System.Drawing.Point(12, 48);
            this.ButStart.Name = "ButStart";
            this.ButStart.Size = new System.Drawing.Size(75, 43);
            this.ButStart.TabIndex = 1;
            this.ButStart.Text = "Start";
            this.ButStart.UseVisualStyleBackColor = true;
            this.ButStart.Click += new System.EventHandler(this.ButStart_Click);
            // 
            // ButStop
            // 
            this.ButStop.Enabled = false;
            this.ButStop.Location = new System.Drawing.Point(93, 48);
            this.ButStop.Name = "ButStop";
            this.ButStop.Size = new System.Drawing.Size(75, 43);
            this.ButStop.TabIndex = 2;
            this.ButStop.Text = "Stop";
            this.ButStop.UseVisualStyleBackColor = true;
            this.ButStop.Click += new System.EventHandler(this.ButStop_Click);
            // 
            // LblStopwatchInfo
            // 
            this.LblStopwatchInfo.AutoSize = true;
            this.LblStopwatchInfo.Location = new System.Drawing.Point(14, 12);
            this.LblStopwatchInfo.Name = "LblStopwatchInfo";
            this.LblStopwatchInfo.Size = new System.Drawing.Size(197, 20);
            this.LblStopwatchInfo.TabIndex = 0;
            this.LblStopwatchInfo.Text = "Using the Stopwatch class";
            // 
            // ButRead
            // 
            this.ButRead.Location = new System.Drawing.Point(12, 97);
            this.ButRead.Name = "ButRead";
            this.ButRead.Size = new System.Drawing.Size(156, 43);
            this.ButRead.TabIndex = 5;
            this.ButRead.Text = "Read Interval";
            this.ButRead.UseVisualStyleBackColor = true;
            this.ButRead.Click += new System.EventHandler(this.ButRead_Click);
            // 
            // ButReadMilli
            // 
            this.ButReadMilli.Location = new System.Drawing.Point(174, 97);
            this.ButReadMilli.Name = "ButReadMilli";
            this.ButReadMilli.Size = new System.Drawing.Size(156, 43);
            this.ButReadMilli.TabIndex = 6;
            this.ButReadMilli.Text = "Read Milliseconds";
            this.ButReadMilli.UseVisualStyleBackColor = true;
            this.ButReadMilli.Click += new System.EventHandler(this.ButReadMilli_Click);
            // 
            // ButReadTicks
            // 
            this.ButReadTicks.Location = new System.Drawing.Point(336, 97);
            this.ButReadTicks.Name = "ButReadTicks";
            this.ButReadTicks.Size = new System.Drawing.Size(156, 43);
            this.ButReadTicks.TabIndex = 7;
            this.ButReadTicks.Text = "Read Ticks";
            this.ButReadTicks.UseVisualStyleBackColor = true;
            this.ButReadTicks.Click += new System.EventHandler(this.ButReadTicks_Click);
            // 
            // ButReset
            // 
            this.ButReset.Location = new System.Drawing.Point(255, 48);
            this.ButReset.Name = "ButReset";
            this.ButReset.Size = new System.Drawing.Size(75, 43);
            this.ButReset.TabIndex = 4;
            this.ButReset.Text = "Reset";
            this.ButReset.UseVisualStyleBackColor = true;
            this.ButReset.Click += new System.EventHandler(this.ButReset_Click);
            // 
            // ButRestart
            // 
            this.ButRestart.Location = new System.Drawing.Point(174, 48);
            this.ButRestart.Name = "ButRestart";
            this.ButRestart.Size = new System.Drawing.Size(75, 43);
            this.ButRestart.TabIndex = 3;
            this.ButRestart.Text = "Restart";
            this.ButRestart.UseVisualStyleBackColor = true;
            this.ButRestart.Click += new System.EventHandler(this.ButRestart_Click);
            // 
            // ButClear
            // 
            this.ButClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButClear.Location = new System.Drawing.Point(12, 378);
            this.ButClear.Name = "ButClear";
            this.ButClear.Size = new System.Drawing.Size(75, 43);
            this.ButClear.TabIndex = 9;
            this.ButClear.Text = "Clear";
            this.ButClear.UseVisualStyleBackColor = true;
            this.ButClear.Click += new System.EventHandler(this.ButClear_Click);
            // 
            // GrpBackground
            // 
            this.GrpBackground.Controls.Add(this.RdoToggle);
            this.GrpBackground.Controls.Add(this.LblMilliseconds);
            this.GrpBackground.Controls.Add(this.TxtTickTime);
            this.GrpBackground.Controls.Add(this.ButTicker);
            this.GrpBackground.Location = new System.Drawing.Point(498, 15);
            this.GrpBackground.Name = "GrpBackground";
            this.GrpBackground.Size = new System.Drawing.Size(121, 128);
            this.GrpBackground.TabIndex = 10;
            this.GrpBackground.TabStop = false;
            this.GrpBackground.Text = "Ticker";
            // 
            // RdoToggle
            // 
            this.RdoToggle.AutoSize = true;
            this.RdoToggle.Enabled = false;
            this.RdoToggle.Location = new System.Drawing.Point(86, 47);
            this.RdoToggle.Name = "RdoToggle";
            this.RdoToggle.Size = new System.Drawing.Size(21, 20);
            this.RdoToggle.TabIndex = 13;
            this.RdoToggle.TabStop = true;
            this.RdoToggle.UseVisualStyleBackColor = true;
            // 
            // LblMilliseconds
            // 
            this.LblMilliseconds.AutoSize = true;
            this.LblMilliseconds.Location = new System.Drawing.Point(86, 96);
            this.LblMilliseconds.Name = "LblMilliseconds";
            this.LblMilliseconds.Size = new System.Drawing.Size(30, 20);
            this.LblMilliseconds.TabIndex = 14;
            this.LblMilliseconds.Text = "ms";
            // 
            // TxtTickTime
            // 
            this.TxtTickTime.Location = new System.Drawing.Point(6, 93);
            this.TxtTickTime.MaxLength = 7;
            this.TxtTickTime.Name = "TxtTickTime";
            this.TxtTickTime.Size = new System.Drawing.Size(74, 26);
            this.TxtTickTime.TabIndex = 12;
            this.TxtTickTime.Text = "1000";
            // 
            // ButTicker
            // 
            this.ButTicker.Location = new System.Drawing.Point(5, 36);
            this.ButTicker.Name = "ButTicker";
            this.ButTicker.Size = new System.Drawing.Size(75, 43);
            this.ButTicker.TabIndex = 11;
            this.ButTicker.Text = "Run";
            this.ButTicker.UseVisualStyleBackColor = true;
            this.ButTicker.Click += new System.EventHandler(this.ButTicker_Click);
            // 
            // FrmStopwatchTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 438);
            this.Controls.Add(this.GrpBackground);
            this.Controls.Add(this.ButClear);
            this.Controls.Add(this.ButReset);
            this.Controls.Add(this.ButRestart);
            this.Controls.Add(this.ButReadTicks);
            this.Controls.Add(this.ButReadMilli);
            this.Controls.Add(this.ButRead);
            this.Controls.Add(this.LblStopwatchInfo);
            this.Controls.Add(this.ButStop);
            this.Controls.Add(this.ButStart);
            this.Controls.Add(this.LstStatus);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(364, 354);
            this.Name = "FrmStopwatchTest";
            this.Text = "Stopwatch Test";
            this.Load += new System.EventHandler(this.FrmStopwatchTest_Load);
            this.GrpBackground.ResumeLayout(false);
            this.GrpBackground.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LstStatus;
        private System.Windows.Forms.Button ButStart;
        private System.Windows.Forms.Button ButStop;
        private System.Windows.Forms.Label LblStopwatchInfo;
        private System.Windows.Forms.Button ButRead;
        private System.Windows.Forms.Button ButReadMilli;
        private System.Windows.Forms.Button ButReadTicks;
        private System.Windows.Forms.Button ButReset;
        private System.Windows.Forms.Button ButRestart;
        private System.Windows.Forms.Button ButClear;
        private System.Windows.Forms.GroupBox GrpBackground;
        private System.Windows.Forms.RadioButton RdoToggle;
        private System.Windows.Forms.Label LblMilliseconds;
        private System.Windows.Forms.TextBox TxtTickTime;
        private System.Windows.Forms.Button ButTicker;
        private System.ComponentModel.BackgroundWorker BgrdWorker;
    }
}

