using System.ComponentModel;
using System.Diagnostics;
using System.Threading;

namespace Ticker 
{
    public class Tick : BackgroundWorker
    {
        Stopwatch sw = new Stopwatch();
        bool ticking;
        public bool Ticking {
            get { return ticking; }
        }
        public int Milliseconds { get; set; } = 100;

        public void Start()
        {
            if (IsBusy != true)
            {
                RunWorkerAsync();
            }
        }

        public void Stop()
        {
            ticking = false;
        }

        public Tick(ProgressChangedEventHandler CallOnTick)
        {
            WorkerReportsProgress = true;
            ProgressChanged += CallOnTick;
            DoWork += RunStopwatch;
        }

        private void RunStopwatch(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            long diff = 0;
            long nextTrigger = 0;
            int tick = 0;   //toggles from 1 to 0 and sent back via progress

            sw.Start();
            ticking = sw.IsRunning;
            do
            {
                nextTrigger = sw.ElapsedMilliseconds + Milliseconds;
                do
                {
                    Thread.Sleep(1);    //or Thread.Sleep(0)
                    diff = nextTrigger - sw.ElapsedMilliseconds;
                } while (diff > 0);
                //Display tick
                worker.ReportProgress(tick);
                if (tick == 0)
                    tick = 1;
                else
                    tick = 0;
            } while (ticking);
            sw.Stop();
            sw.Reset();
        }
    }
}
