using System;

namespace PmLibrary
{
    public enum ProcessingStatus
    {
        None = 0,

        Processing = 10,
        Paused = 11,
        Scheduled = 12,
        
        Done = 20,
        Stopped = 21,
        Error = 22,
        Halted = 23,        
    }
    
}