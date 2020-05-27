using System;
using System.Collections.Generic;
using System.Text;

namespace MdcLog.Domain.Entities
{
    class LogHandler
    {
        public int Uid { get; set; }
        public int UserSeqNum { get; set; }
        public string Code { get; set; }
        public string Tmma { get; set; }
    }
}
