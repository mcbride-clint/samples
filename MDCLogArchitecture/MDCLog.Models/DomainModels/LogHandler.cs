using MDCLogArchitecture.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MDCLogArchitecture.Models.DomainModels
{
    public class LogHandler : ILogHandler
    {
        public int UserSeqNum { get; set; }
        public string Code { get; set; }
        public string Tmma { get; set; }
    }
}
