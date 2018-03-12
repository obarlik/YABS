using System;
using System.Collections.Generic;
using System.Text;

namespace PmLibrary
{
    /// <summary>
    /// Calls subprocess, sets current step's result value,
    /// and continues with next route
    /// </summary>
    public interface IPmCallSubProcess : IPmProcessStep
    {
        /// <summary>
        /// Subprocess to be called
        /// </summary>
        IPmProcess SubProcess { get; set; }
    }
}
