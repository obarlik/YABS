using System;
using System.Collections.Generic;
using System.Text;

namespace PmLibrary
{
    /// <summary>
    /// Declares a running/finalized process state.
    /// </summary>
    public interface IProcessState
    {
        /// <summary>
        /// Process definition of this state
        /// </summary>
        IProcess Process { get; set; }


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
        /// Current step's state information
        /// </summary>
        IStepState StepState { get; }
        

        /// <summary>
        /// Step state stack
        /// </summary>
        Stack<IStepState> Stack { get; }


        /// <summary>
        /// Step state history
        /// </summary>
        IEnumerable<IStepState> History { get; }

        
        /// <summary>
        /// Process variable values
        /// </summary>
        IDictionary<string, object> Variables { get; }
    }
}
