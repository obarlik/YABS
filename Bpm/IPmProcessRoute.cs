using System;
using System.Collections.Generic;
using System.Text;

namespace PmLibrary
{
    public interface IPmProcessRoute
    {
        IPmProcess Process { get; set; }

        string RequiredResultValue { get; set; }

        IPmProcessStep Origin { get; set; }
        IPmProcessStep Destination { get; set; }
    }
}
