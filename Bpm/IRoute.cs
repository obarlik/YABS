using System;
using System.Collections.Generic;
using System.Text;

namespace PmLibrary
{
    public interface IRoute
    {
        IStep ToStep { get; set; }
        string Criteria { get; set; }
        int CriteriaOrder { get; set; }
    }
}
