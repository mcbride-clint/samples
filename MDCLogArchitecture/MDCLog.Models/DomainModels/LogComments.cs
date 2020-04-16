﻿using System;
using MDCLogArchitecture.Domain.Interfaces;
using System.Collections.Generic;
using System.Text;

namespace MDCLogArchitecture.Models.DomainModels
{
    public class LogComments :ILogComments
    {
        public int SeqNum { get; set; }
        public int LogNumber { get; set; }
        public string Type { get; set; }
        public string TypeDesc { get; set; }
        public string BasicNumber { get; set; }
        public string Comment { get; set; }
        public DateTime CreateDate { get; set; }
        public int CreatedBySeqNum { get; set; }
        public string CreatedBy { get; set; }
        public int LinkToSeqNum { get; set; }
    }
}
