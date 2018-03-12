using System;
using System.Collections.Generic;
using System.Text;

namespace PmLibrary
{
    public interface IPmSetVariableStep : IPmProcessStep
    {
        string VariableName { get; set; }
        string NewValue { get; set; }
    }
}
