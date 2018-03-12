using System;
using System.Collections.Generic;
using System.Text;

namespace PmLibrary
{
    /// <summary>
    /// Process step
    /// </summary>
    public interface IPmProcessStep
    {
        /// <summary>
        /// Parent process
        /// </summary>
        IPmProcess Process { get; set; }


        /// <summary>
        /// Associated position definition, if any
        /// </summary>
        IPmPosition Position { get; set; }


        /// <summary>
        /// Additional notes about this step
        /// </summary>
        string Notes { get; set; }

        
        /// <summary>
        /// Step evaluation function
        /// </summary>
        /// <param name="processState"></param>
        /// <returns></returns>
        string Run(IPmProcessState processState);


        /// <summary>
        /// Returns next route according to result value.
        /// </summary>
        /// <param name="result"></param>
        /// <returns></returns>
        IPmProcessStep GetNextStep(string result);
    }
}
