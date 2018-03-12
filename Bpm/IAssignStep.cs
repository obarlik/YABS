﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PmLibrary
{
    /// <summary>
    /// Value assigning step type. 
    /// Assigns expression result value to a variable
    /// </summary>
    public interface IAssignStep : IStep
    {
        /// <summary>
        /// Value name to be assigned
        /// </summary>
        string VariableName { get; set; }


        /// <summary>
        /// New value expression to be evaluated
        /// </summary>
        string ValueExpression { get; set; }
    }
}
