using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
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
            get { return sendTimer.Enabled; }
        }
        private int interval;
        public int Interval
        {
            get { return interval; }
            set
            {
                interval = value;
                sendTimer.Interval = value;
            }
        }
        private String destination;
        public String Destination
        {
            get { return destination; }
            set { destination = value; }
        }
        

        private Timer sendTimer = new Timer();
        private Timer statusInformer = new Timer();
        private Int32 sentPackages = 0;

        public WorkaroundPingflooder(String destination, int interval)
        {
            this.destination = destination;
            sendTimer.Interval = interval;
            sendTimer.Elapsed += new ElapsedEventHandler(timer_executeSinglePing);

            statusInformer.Interval = STATUSINFORMER_TIMING;
            statusInformer.Elapsed += new ElapsedEventHandler(timer_handleStatus);
        }

  

        public void start()
        {
            sendTimer.Start();
            statusInformer.Start();
        }

        public void stop()
        {
            sendTimer.Stop();
            statusInformer.Stop();
        }

        public void restart()
        {
            if (sendTimer.Enabled) {
                stop();
                start();
            }
        }


        private void timer_executeSinglePing(object sender, ElapsedEventArgs e)
        {
            Ping pinger = new Ping(); // a new object should not be needed, but one object can't send more than 1 ping per time
            pinger.Send(destination, PING_TIMEOUT, PING_PACKET);
            lock(this)
                sentPackages++;
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
