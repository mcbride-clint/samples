using System;
using System.Collections.Generic;
using System.Text;

namespace MDCLogArchitecture.Domain.Interfaces
{
    public interface ILogComments
    {
        int SeqNum { get; set; }
        int LogNumber { get; set; }
        string Type { get; set; }
        string TypeDesc { get; set; }
        string BasicNumber { get; set; }
        string Comment { get; set; }
        DateTime CreateDate { get; set; }
        int CreatedBySeqNum { get; set; }
        string CreatedBy { get; set; }
        int LinkToSeqNum { get; set; }
    }
}
