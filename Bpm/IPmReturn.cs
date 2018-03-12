using System;
using System.Collections.Generic;
using System.Text;

namespace PmLibrary
{
    /// <summary>
    /// Returns value of expression's result
    /// </summary>
    public interface IPmReturn : IPmProcessStep
    {
        /// <summary>
        /// C# expression to be evaluated
        /// </summary>
        string Expression { get; set; }
    }
}
