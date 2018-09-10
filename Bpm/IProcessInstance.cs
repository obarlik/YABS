using System;
using System.Collections.Generic;
using System.Text;

namespace PmLibrary
{
    /// <summary>
    /// Declares a running/finalized process instance.
    /// </summary>
    public interface IProcessInstance
    {
        /// <summary>
        /// Runs under this parent process, if any
        /// </summary>
        IProcessInstance ParentProcessInstance { get; set; }
       

        /// <summary>
        /// Process definition of this instance
        /// </summary>
        IProcess Process { get; set; }


        /// <summary>
        /// Current status
        /// </summary>
        ProcessingStatus Status { get; set; }


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
        TimeSpan? Duration { get; }


        /// <summary>
        /// Current step's instance
        /// </summary>
        IStepInstance StepInstance { get; }
        

        /// <summary>
        /// Step instance stack
        /// </summary>
        Stack<IStepInstance> Stack { get; }


        /// <summary>
        /// Step instance history
        /// </summary>
        IEnumerable<IStepInstance> History { get; }

        
        /// <summary>
        /// Process variable values
        /// </summary>
        IDictionary<string, object> Variables { get; }
    }
}
