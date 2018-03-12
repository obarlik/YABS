using System;
using System.Collections.Generic;
using System.Text;

namespace PmLibrary
{
    /// <summary>
    /// Defines a process
    /// </summary>
    public interface IPmProcess
    {
        string Code { get; set; }
        string Name { get; set; }

        IPmProcessStep StartStep { get; set; }
        IPmProcessStep FinishStep { get; set; }

        string Notes { get; set; }

        string RevisedBy { get; set; }
        DateTime RevisionTime { get; set; }

        int Revision { get; set; }

        int VersionMajor { get; set; }
        int VersionMinor { get; set; }

        DateTime ValidFrom { get; set; }
        DateTime? ValidTo { get; set; }
    }
}
