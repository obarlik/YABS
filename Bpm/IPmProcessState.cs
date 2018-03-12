using System;
using System.Collections.Generic;
using System.Text;

namespace PmLibrary
{
    /// <summary>
    /// Declares a running/finalized process state.
    /// </summary>
    public interface IPmProcessState
    {
        /// <summary>
        /// Current status
        /// </summary>
        PmStatus Status { get; set; }


        /// <summary>
        /// Process start time
        /// </summary>
        DateTime StartedAt { get; set; }


        /// <summary>
        /// Process finish time
        /// </summary>
        DateTime? FinishedAt { get; set; }


        /// <summary>
        /// Elapsed time until start time.
        /// </summary>
        TimeSpan Duration { get; }


        /// <summary>
        /// Last step state information
        /// </summary>
        IPmProcessStepState LastStep { get; }
        

        /// <summary>
        /// 
        /// </summary>
        Stack<IPmProcessStepState> Stack { get; }


        Queue<IPmProcessStepState> History { get; }
    }
}
