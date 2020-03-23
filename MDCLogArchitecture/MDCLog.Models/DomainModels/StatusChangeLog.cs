using System;
using System.Collections.Generic;
using System.Text;

namespace MDCLogArchitecture.Models.DomainModels
{
    public class MDCStatusChangeLog
    {
        public int StatusChangeSeqNum { get; set; }
        public int LogNumber { get; set; }
        public string FromStatus { get; set; }
        public string ToStatus { get; set; }
        public int StatusChangedBySeqNum { get; set; }
        public DateTime StatusChangedDate { get; set; }

    }
}


