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
            this.SuspendLayout();
            // 
            // LstStatus
            // 
            this.LstStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LstStatus.FormattingEnabled = true;
            this.LstStatus.Location = new System.Drawing.Point(8, 97);
            this.LstStatus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LstStatus.Name = "LstStatus";
            this.LstStatus.Size = new System.Drawing.Size(320, 82);
            this.LstStatus.TabIndex = 8;
            // 
            // ButStart
            // 
            this.ButStart.Location = new System.Drawing.Point(8, 31);
            this.ButStart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ButStart.Name = "ButStart";
            this.ButStart.Size = new System.Drawing.Size(50, 28);
            this.ButStart.TabIndex = 1;
            this.ButStart.Text = "Start";
            this.ButStart.UseVisualStyleBackColor = true;
            this.ButStart.Click += new System.EventHandler(this.ButStart_Click);
            // 
            // ButStop
            // 
            this.ButStop.Enabled = false;
            this.ButStop.Location = new System.Drawing.Point(62, 31);
            this.ButStop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ButStop.Name = "ButStop";
            this.ButStop.Size = new System.Drawing.Size(50, 28);
            this.ButStop.TabIndex = 2;
            this.ButStop.Text = "Stop";
            this.ButStop.UseVisualStyleBackColor = true;
            this.ButStop.Click += new System.EventHandler(this.ButStop_Click);
            // 
            // LblStopwatchInfo
            // 
            this.LblStopwatchInfo.AutoSize = true;
            this.LblStopwatchInfo.Location = new System.Drawing.Point(9, 8);
            this.LblStopwatchInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblStopwatchInfo.Name = "LblStopwatchInfo";
            this.LblStopwatchInfo.Size = new System.Drawing.Size(133, 13);
            this.LblStopwatchInfo.TabIndex = 0;
            this.LblStopwatchInfo.Text = "Using the Stopwatch class";
            // 
            // ButRead
            // 
            this.ButRead.Location = new System.Drawing.Point(8, 63);
            this.ButRead.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ButRead.Name = "ButRead";
            this.ButRead.Size = new System.Drawing.Size(104, 28);
            this.ButRead.TabIndex = 5;
            this.ButRead.Text = "Read Interval";
            this.ButRead.UseVisualStyleBackColor = true;
            this.ButRead.Click += new System.EventHandler(this.ButRead_Click);
            // 
            // ButReadMilli
            // 
            this.ButReadMilli.Location = new System.Drawing.Point(116, 63);
            this.ButReadMilli.Margin = new System.Windows.Forms.Padding(2);
            this.ButReadMilli.Name = "ButReadMilli";
            this.ButReadMilli.Size = new System.Drawing.Size(104, 28);
            this.ButReadMilli.TabIndex = 6;
            this.ButReadMilli.Text = "Read Milliseconds";
            this.ButReadMilli.UseVisualStyleBackColor = true;
            this.ButReadMilli.Click += new System.EventHandler(this.ButReadMilli_Click);
            // 
            // ButReadTicks
            // 
            this.ButReadTicks.Location = new System.Drawing.Point(224, 63);
            this.ButReadTicks.Margin = new System.Windows.Forms.Padding(2);
            this.ButReadTicks.Name = "ButReadTicks";
            this.ButReadTicks.Size = new System.Drawing.Size(104, 28);
            this.ButReadTicks.TabIndex = 7;
            this.ButReadTicks.Text = "Read Ticks";
            this.ButReadTicks.UseVisualStyleBackColor = true;
            this.ButReadTicks.Click += new System.EventHandler(this.ButReadTicks_Click);
            // 
            // ButReset
            // 
            this.ButReset.Location = new System.Drawing.Point(170, 31);
            this.ButReset.Margin = new System.Windows.Forms.Padding(2);
            this.ButReset.Name = "ButReset";
            this.ButReset.Size = new System.Drawing.Size(50, 28);
            this.ButReset.TabIndex = 4;
            this.ButReset.Text = "Reset";
            this.ButReset.UseVisualStyleBackColor = true;
            this.ButReset.Click += new System.EventHandler(this.ButReset_Click);
            // 
            // ButRestart
            // 
            this.ButRestart.Location = new System.Drawing.Point(116, 31);
            this.ButRestart.Margin = new System.Windows.Forms.Padding(2);
            this.ButRestart.Name = "ButRestart";
            this.ButRestart.Size = new System.Drawing.Size(50, 28);
            this.ButRestart.TabIndex = 3;
            this.ButRestart.Text = "Restart";
            this.ButRestart.UseVisualStyleBackColor = true;
            this.ButRestart.Click += new System.EventHandler(this.ButRestart_Click);
            // 
            // FrmStopwatchTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 186);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmStopwatchTest";
            this.Text = "Stopwatch Test";
            this.Load += new System.EventHandler(this.FrmStopwatchTest_Load);
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
    }
}

