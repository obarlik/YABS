using System;
using System.Collections.Generic;
using System.Text;

namespace PmLibrary
{
    /// <summary>
    /// Calls subprocess, sets current step's result value,
    /// returns upon completion.
    /// </summary>
    public interface ICallerStep : IStep
    {
        /// <summary>
        /// Subprocess to be called
        /// </summary>
        IProcess SubProcess { get; set; }
    }
}
