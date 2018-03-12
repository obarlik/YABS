using System;
using System.Collections.Generic;
using System.Text;

namespace PmLibrary
{
    public interface IPmProcessStepState
    {
        PmStatus Status { get; set; }

        IPmProcessStep Step { get; set; }

        DateTime StepStartedAt { get; set; }
        DateTime? StepFinishedAt { get; set; }
        TimeSpan StepDuration { get; }

        string Result { get; set; }
        string ErrorMessage { get; set; }

        IDictionary<string, object> Locals { get; }
    }
}
