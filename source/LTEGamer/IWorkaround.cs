using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTEGamer
{
    interface IWorkaround
    {

        WorkaroundStatusHandler StatusHandler { get; set; }
        bool Running { get; }

        void start();
        void stop();
        void restart();

    }
}
