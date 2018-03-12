using System;
using System.Collections.Generic;
using System.Text;

namespace PmLibrary
{
    /// <summary>
    /// Defines a process
    /// </summary>
    public interface IProcess
    {
        /// <summary>
        /// Serial number 
        /// </summary>
        int ProcessNo { get; set; }


        /// <summary>
        /// Name 
        /// </summary>
        string Name { get; set; }


        /// <summary>
        /// Start step of this process
        /// </summary>
        IStep StartStep { get; set; }
        
        
        /// <summary>
        /// Notes for this step, if any.
        /// </summary>
        string Notes { get; set; }


        /// <summary>
        /// Revision information of this step.
        /// </summary>
        string RevisedBy { get; set; }


        /// <summary>
        /// Revision time of this step
        /// </summary>
        DateTime RevisionTime { get; set; }


        /// <summary>
        /// Revision number of this step
        /// </summary>
        int Revision { get; set; }


        /// <summary>
        /// Major version number
        /// </summary>
        int VersionMajor { get; set; }


        /// <summary>
        /// Minor version number
        /// </summary>
        int VersionMinor { get; set; }


        /// <summary>
        /// Valid from date/time
        /// </summary>
        DateTime ValidFrom { get; set; }


        /// <summary>
        /// Velid to date/time
        /// </summary>
        DateTime? ValidTo { get; set; }


        /// <summary>
        /// Variable definitions for this process
        /// </summary>
        IDictionary<string, IVariable> Variables { get; }


        /// <summary>
        /// Returns next step, that best fits current state
        /// </summary>
        /// <param name="baseStep"></param>
        /// <returns></returns>
        IStep GetNextStep();
    }
}
