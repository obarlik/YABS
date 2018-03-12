using System;
using System.Collections.Generic;
using System.Text;

namespace PmLibrary
{
    /// <summary>
    /// Declares a running/finalized step's state data
    /// </summary>
    public interface IStepState
    {
        /// <summary>
        /// Step definition of this state
        /// </summary>
        IStep Step { get; set; }


        /// <summary>
        /// State's current status
        /// </summary>
        PmStatus Status { get; set; }

        
        /// <summary>
        /// Step start time
        /// </summary>
        DateTime StepStartedAt { get; set; }


        /// <summary>
        /// Step finish time
        /// </summary>
        DateTime? StepFinishedAt { get; set; }


        /// <summary>
        /// Step duration time
        /// </summary>
        TimeSpan StepDuration { get; }


        /// <summary>
        /// Step result value
        /// </summary>
        string Result { get; set; }


        /// <summary>
        /// Step error message, if any exception exists
        /// </summary>
        string ErrorMessage { get; set; }


        /// <summary>
        /// Step local variable values
        /// </summary>
        IDictionary<string, object> Variables { get; }
    }
}
