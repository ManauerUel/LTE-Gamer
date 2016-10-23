using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTEGamer
{
  
    public delegate void ProcessStatusHandler(ProcessStatus status);
    public enum ProcessStatus
    {
        PROCESS_FOUND,
        NO_PROCESS_FOUND
    }


    public delegate void MessageHandler(String message, MessageType type);
    public enum MessageType
    {
        MESSAGE, ERROR, STATUS
    }


    public delegate void WorkaroundStatusHandler(String message);
}
