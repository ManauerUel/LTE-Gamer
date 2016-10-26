using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace LTEGamer
{



    class WorkaroundPingflooder : IWorkaround
    {
        private static readonly int PING_TIMEOUT = 1000;
        private static readonly int PING_SIZE = 32;
        private static readonly byte[] PING_PACKET = new byte[PING_SIZE];
        private static readonly int STATUSINFORMER_TIMING = 1000;

        public WorkaroundStatusHandler StatusHandler { get; set; }
        public bool Running
        {
            get { return processRun; }
        }

        public int Interval { get; set; }

        private String destination;
        public String Destination
        {
            get { return destination; }
            set { destination = value; }
        }
        

        private System.Timers.Timer statusInformer = new System.Timers.Timer();
        private Int32 sentPackages = 0;
        private volatile bool processRun;
        private Thread sendThread;

        public WorkaroundPingflooder(String destination, int interval)
        {
            this.destination = destination;
            this.Interval = interval;

            statusInformer.Interval = STATUSINFORMER_TIMING;
            statusInformer.Elapsed += new ElapsedEventHandler(timer_handleStatus);
        }

  

        public void start()
        {
            processRun = true;
            sendThread = new Thread(threaded_pingFlood);
            sendThread.Start();
            statusInformer.Start();
        }

        public void stop()
        {
            processRun = false;
            statusInformer.Stop();
        }

        public void restart()
        {
            if (processRun)
            {
                stop();
                sendThread.Join();
                start();
            }
        }


        
        private void threaded_pingFlood()
        {
            while (processRun) {
                DateTime start = DateTime.Now;

                // a new object should not be needed, but one object can't send more than 1 ping per time
                Ping pinger = new Ping();
                pinger.SendAsync(destination, PING_TIMEOUT, PING_PACKET);
                lock (this)
                    sentPackages++;

                TimeSpan elapsed = DateTime.Now - start;
                int waitingTime = Interval - (int)elapsed.TotalMilliseconds;
                Thread.Sleep(waitingTime > 0 ? waitingTime : 0);
            }
        }

        private void timer_handleStatus(object sender, ElapsedEventArgs e)
        {
            int temp;
            lock (this)
            {
                temp = sentPackages;
                sentPackages = 0;
            }
            StatusHandler.Invoke("Pinge " + temp + " Pakete/s");

        }

    }
}
