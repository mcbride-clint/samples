using MDCLogArchitecture.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MDCLogArchitecture.Models.Filters
{
    public class LogHandlersFilter 
    {
        int? UserSeqNum { get; set; }
        string Code { get; set; }
        string Tmma { get; set; }

    }
}
