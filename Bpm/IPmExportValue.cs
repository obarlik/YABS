using System;
using System.Collections.Generic;
using System.Text;

namespace PmLibrary
{
    /// <summary>
    /// Exports value to process state
    /// </summary>
    public interface IPmExportValue : IPmProcessStep
    {
        /// <summary>
        /// Local variable name to be exported
        /// </summary>
        string ValueName { get; set; }
    }
}
