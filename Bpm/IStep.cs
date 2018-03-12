using System;
using System.Collections.Generic;
using System.Text;

namespace PmLibrary
{
    /// <summary>
    /// Process step
    /// </summary>
    public interface IStep
    {
        /// <summary>
        /// Step serial number
        /// </summary>
        int StepNo { get; set; }


        /// <summary>
        /// Associated position definition, if any
        /// </summary>
        IPosition Position { get; set; }


        /// <summary>
        /// Additional notes about this step
        /// </summary>
        string Notes { get; set; }

        
        /// <summary>
        /// Step evaluation function definition
        /// </summary>
        /// <param name="processState">Current process state</param>
        /// <returns></returns>
        object Run(IProcessState processState);


        /// <summary>
        /// Variable definitions for this step
        /// </summary>
        IDictionary<string, IVariable> Variables { get; }


        /// <summary>
        /// Route definitions for this step
        /// </summary>
        IList<IRoute> Routes { get; }
    }
}
