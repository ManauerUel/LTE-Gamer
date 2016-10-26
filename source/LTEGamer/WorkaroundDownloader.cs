using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace LTEGamer
{
    class WorkaroundDownloader : IWorkaround
    {

        private readonly int LOADING_INTERVAL = 1000; //ms
        private static readonly int STATUSINFORMER_TIMING = 1000;


        public WorkaroundStatusHandler StatusHandler { get; set; }
        public bool Running
        {
            get { return downloadThread.IsAlive; }
        }

        private int bytesPerSecond;
        public int MbitsPerSecond
        {
            get { return bytesPerSecond / 1024 * 8 / 1024; }
            set
            {
                bytesPerSecond = value * 1024 * 1024 / 8;
                restart();
            }
        }

        private String file;
        public String File
        {
            get { return file; }
            set
            {
                file = value;
                restart();
            }
        }



        private volatile int receivedBytes = 0;
        private volatile bool processRun;
        private Thread downloadThread;
        private System.Timers.Timer statusInformer = new System.Timers.Timer();



        public WorkaroundDownloader(String file, int mbitsPerSecond)
        {
            this.file = file;

            MbitsPerSecond = mbitsPerSecond;
            
            statusInformer.Interval = STATUSINFORMER_TIMING;
            statusInformer.Elapsed += new System.Timers.ElapsedEventHandler(timer_handleStatus);
        }

        public void start()
        {
            processRun = true;
            downloadThread = new Thread(threaded_downloadFile);
            downloadThread.Start();
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
                downloadThread.Join();
                start();
            }
        }


        private void threaded_downloadFile()
        {

            //DEBUG OUTPUT
            //Console.WriteLine("PER SECOND: " + bytesPerSecond + " bytes || " + bytesPerSecond/1024 + " kbytes || " + bytesPerSecond/1024.0/1024 + "mbytes");
            //Console.WriteLine("Download every ms: " + LOADING_INTERVAL);
            //Console.WriteLine("BUFFER LENGTH: " + bytesPerSecond / (1000 / LOADING_INTERVAL)+" bytes || " + bytesPerSecond / (1000 / LOADING_INTERVAL) / 1024 + " kbytes || " + bytesPerSecond / (1000 / LOADING_INTERVAL) / 1024.0/1024 + " mbytes");

            while (processRun) //start file-download
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(file);
                request.Method = "GET";
                request.Credentials = CredentialCache.DefaultCredentials;

                using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                using (Stream input = response.GetResponseStream())
                {
                    byte[] buffer = new byte[bytesPerSecond / (1000 / LOADING_INTERVAL)]; //get bytes per second splitted to bytes per interval

                    int size = input.Read(buffer, 0, buffer.Length);
                    while(size > 0 && processRun) //read next bytes
                    {
                        DateTime start = DateTime.Now;

                        //Stream.Null.Write(buffer, 0, size); //writing the bytes to null
                        lock(this)
                            receivedBytes += size;

                        size = input.Read(buffer, 0, buffer.Length);

                        TimeSpan elapsed = DateTime.Now - start;
                        int waitingTime = LOADING_INTERVAL - (int)elapsed.TotalMilliseconds;
                        Thread.Sleep(waitingTime > 0 ? waitingTime : 0);

                        //Console.WriteLine(size + " bytes read");
                    }
                }
            }
        }


        private void timer_handleStatus(object sender, System.Timers.ElapsedEventArgs e)
        {
            double currentBandwith;
            lock (this)
            {
                currentBandwith = receivedBytes / 1024.0 * 8.0 / 1024.0;
                receivedBytes = 0;
            }
            StatusHandler.Invoke("Download mit " + Math.Round(currentBandwith,2) + " Mbit/s");
            
        }


    }
}
