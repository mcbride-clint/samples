using System;
using System.Collections.Generic;
using System.Text;

namespace MDCLogArchitecture.Domain.Interfaces
{
    public interface ILogHandler
    {
        string UserSeqNum { get; set; }
        string Code { get; set; }
        string Tmma { get; set; }
    }
}
