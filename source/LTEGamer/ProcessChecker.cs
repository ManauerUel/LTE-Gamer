using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Management;

namespace LTEGamer
{
    
    class ProcessFinder
    {
        private readonly int CHECK_PROCESSES_TIME = 3000;

        public ProcessStatusHandler ChangedStatusHandler { get; set; }

        private List<String> executableList = new List<String>();
        private ProcessStatus lastStatus = ProcessStatus.NO_PROCESS_FOUND;
        private Timer checkingTimer = new Timer();


        public ProcessFinder()
        {
            checkingTimer.Interval = CHECK_PROCESSES_TIME;
            checkingTimer.Elapsed += new ElapsedEventHandler(checkProcesses);
        }

        public void start()
        {
            checkingTimer.Start();
        }

        public void stop()
        {
            checkingTimer.Stop();
        }


        public void addExecutablePath(String path)
        {
            executableList.Add(path.ToLower());
        }

        public void removeExecutablePath(String path)
        {
            executableList.Remove(path.ToLower());
        }

        public void clearExecutablePaths()
        {
            executableList.Clear();
        }



        private void checkProcesses(object sender, ElapsedEventArgs e)
        {
            var wmiQueryString = "SELECT ProcessId, ExecutablePath, CommandLine FROM Win32_Process";
            using (var searcher = new ManagementObjectSearcher(wmiQueryString))
            using (var results = searcher.Get())
            {
                var query = from p in Process.GetProcesses()
                            join mo in results.Cast<ManagementObject>()
                            on p.Id equals (int)(uint)mo["ProcessId"]
                            where (string)mo["ExecutablePath"] != null && executableList.Contains(((string)mo["ExecutablePath"]).ToLower())
                            select new
                            {
                                Process = p,
                                Path = (string)mo["ExecutablePath"],
                                CommandLine = (string)mo["CommandLine"],
                            };

                ProcessStatus newStatus = query.Count() > 0 ? ProcessStatus.PROCESS_FOUND : ProcessStatus.NO_PROCESS_FOUND;
                if (lastStatus != newStatus)
                {
                    lastStatus = newStatus;
                    ChangedStatusHandler.Invoke(newStatus);
                }


            }
        }


    }
}
