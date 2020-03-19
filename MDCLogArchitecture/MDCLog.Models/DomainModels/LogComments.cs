﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MDCLog.Models.DomainModels
{
    class LogComments
    {
        public int SeqNum { get; set; }
        public int LogNumber { get; set; }
        public string Type { get; set; }
        public string BasicNumber { get; set; }
        public string Comment { get; set; }
        public string CreateDate { get; set; }
        public int CreatedBySeqNum { get; set; }
        public int LinkToSeqNum { get; set; }
    }
}
