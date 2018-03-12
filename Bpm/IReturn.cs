using System;
using System.Collections.Generic;
using System.Text;

namespace PmLibrary
{
    /// <summary>
    /// Returns value of expression's result
    /// </summary>
    public interface IReturn : IStep
    {
        /// <summary>
        /// C# expression to be evaluated and assign to result
        /// </summary>
        string Expression { get; set; }
    }
}
