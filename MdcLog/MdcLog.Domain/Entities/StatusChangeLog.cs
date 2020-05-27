using System;
using System.Collections.Generic;
using System.Text;

namespace MdcLog.Domain.Entities
{
    class StatusChangeLog
    {
        public int StatusChangeSeqNum { get; set; }
        public int LogNumber { get; set; }
        public string FromStatus { get; set; }
        public string ToStatus { get; set; }
        public int StatusChangedBySeqNum { get; set; }
        public DateTime StatusChangedDate { get; set; }
    }
}
