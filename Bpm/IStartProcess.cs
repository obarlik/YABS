using System;
using System.Collections.Generic;
using System.Text;

namespace PmLibrary
{
    /// <summary>
    /// Starts another process and returns immediately.
    /// </summary>
    public interface IStartProcess : IStep
    {
        /// <summary>
        /// New process to be started
        /// </summary>
        IProcess NewProcess { get; set; }
    }
}
