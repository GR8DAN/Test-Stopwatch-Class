using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace StopwatchTest
{
    public partial class FrmStopwatchTest : Form
    {
        Stopwatch sw = new Stopwatch();

        public FrmStopwatchTest()
        {
            InitializeComponent();
        }

        private void FrmStopwatchTest_Load(object sender, EventArgs e)
        {
            DisplayTimerProperties();
        }

        void DisplayTimerProperties()
        {
            // Display the timer frequency and resolution.
            if (Stopwatch.IsHighResolution)
            {
                AddMessage("Using the system's high-resolution performance counter.");
            }
            else
            {
                AddMessage("Using the DateTime class.");
            }

            long frequency = Stopwatch.Frequency;
            AddMessage(string.Format("Timer frequency in ticks per second = {0}",frequency));
            long nanosecPerTick = (1000L * 1000L * 1000L) / frequency;
            AddMessage(string.Format("Timer is accurate to within {0} nanoseconds",nanosecPerTick));
        }

        private void ButStart_Click(object sender, EventArgs e)
        {
            if (sw.IsRunning)
            {
                AddMessage("Stopwatch is already running");
                ButStop.Enabled = true;
            }
            else
            {
                sw.Start();
                AddMessage("Stopwatch started");
                ButStop.Enabled = true;
                ButStart.Enabled = false;
            }
        }

        private void ButStop_Click(object sender, EventArgs e)
        {
            if (!sw.IsRunning)
            {
                AddMessage("Stopwatch is already stopped");
                ButStart.Enabled = true;
            }
            else
            {
                sw.Stop();
                AddMessage("Stopwatch stopped");
                ButStart.Enabled = true;
                ButStop.Enabled = false;
            }
        }

        int AddMessage(string MessageToAdd)
        {
            int ret = -1;

            if (LstStatus != null)
            {
                //Limit number of items
                if (LstStatus.Items.Count >= 60000)
                    LstStatus.Items.RemoveAt(0);
                ret = LstStatus.Items.Add(MessageToAdd);
                //ensure new item is visible
                LstStatus.TopIndex = LstStatus.Items.Count - 1;
                return ret;
            }

            return ret;
        }

        private void ButRead_Click(object sender, EventArgs e)
        {
            AddMessage(sw.Elapsed.ToString());
        }

        private void ButReadMilli_Click(object sender, EventArgs e)
        {
            AddMessage(sw.ElapsedMilliseconds.ToString());
        }

        private void ButReadTicks_Click(object sender, EventArgs e)
        {
            AddMessage(sw.ElapsedTicks.ToString());
        }

        private void ButRestart_Click(object sender, EventArgs e)
        {
            sw.Restart();
            ButStop.Enabled = true;
            ButStart.Enabled = false;
            AddMessage("Stopwatch restarted.");
        }

        private void ButReset_Click(object sender, EventArgs e)
        {
            sw.Reset();
            AddMessage("Stopwatch reset.");
            ButStop.Enabled = false;
            ButStart.Enabled = true;
        }
    }
}
