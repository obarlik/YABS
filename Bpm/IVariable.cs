using System;
using System.Collections.Generic;
using System.Text;

namespace PmLibrary
{
    /// <summary>
    /// Step variable
    /// </summary>
    public interface IVariable
    {
        /// <summary>
        /// Variable name
        /// </summary>
        string Name { get; set; }


        /// <summary>
        /// Variable type
        /// </summary>
        Type ResultType { get; set; }


        /// <summary>
        /// Import variable value from upper step/procedure
        /// </summary>
        bool IsInput { get; set; }


        /// <summary>
        /// Export variable value to upper step/process
        /// </summary>
        bool IsOutput { get; set; }
    }
}
