using System;

namespace MDCLogArchitecture.Models.DomainModels
{
    public class LogComment
    {
        public int SeqNum { get; set; }
        public int LogNumber { get; set; }
        public string CommentTypeCode { get; set; }
        public string TypeDesc { get; set; }
        public string BasicNumber { get; set; }
        public string Comment { get; set; }
        public DateTime CreateDate { get; set; }
        public int CreatedBySeqNum { get; set; }
        public string CreatedBy { get; set; }
        public int LinkToSeqNum { get; set; }
    }
}
