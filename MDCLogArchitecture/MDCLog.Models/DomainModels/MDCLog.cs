using System;
using System.Collections.Generic;
using System.Text;

namespace MDCLog.Models.DomainModels
{
    public class MDCLog

    {
        public int LogNumber { get; set; }
        public int TechManualSeqNum { get; set; }
        public string CustomerNum { get; set; }
        public string Source { get; set; }
        public string Status { get; set; }
        public string Priority { get; set; }
        public string CDA { get; set; }
        public int OriginatorSeqNum { get; set; }
        public int WriterSeqNum { get; set; }
        public int CoordinatorSeqNum { get; set; }
        public DateTime NavSeaReviewerAssignedDate { get; set; }
        public int NavSeaReviewerSeqNum { get; set; }
        //Cog engineer left in for historical data prior to new system
        public int CogEngineerSeqNum { get; set; }
        public int BatchSeqNum { get; set; }
        public DateTime LogCreateDate { get; set; }
        public DateTime LogCompletionDate { get; set; }
        public DateTime DeadLineDate { get; set; }
        public DateTime ReconReadyDate { get; set: }

    }
}
