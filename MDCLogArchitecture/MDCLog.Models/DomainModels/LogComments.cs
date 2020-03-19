using System;
using System.Collections.Generic;
using System.Text;

namespace MDCLog.Models.DomainModels
{
    public class LogComments
    {
        public int SeqNum { get; set; }
        public int LogNumber { get; set; }
        public string Type { get; set; }
        public string BasicNumber { get; set; }
        public string Comment { get; set; }
        public DateTime CreateDate { get; set; }
        public int CreatedBySeqNum { get; set; }
        public int LinkToSeqNum { get; set; }
    }
}
