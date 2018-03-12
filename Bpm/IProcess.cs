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
        string Code { get; set; }
        string Name { get; set; }

        IStep StartStep { get; set; }
        IStep FinishStep { get; set; }

        string Notes { get; set; }

        string RevisedBy { get; set; }
        DateTime RevisionTime { get; set; }

        int Revision { get; set; }

        int VersionMajor { get; set; }
        int VersionMinor { get; set; }

        DateTime ValidFrom { get; set; }
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
