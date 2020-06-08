using System;
using System.Collections.Generic;
using System.Text;

namespace MdcLog.Domain.Entities
{
    public class UserId
    {
        public int UserSeqNum { get; set; }
        public string AdFullName { get; set; }
        public string Owner { get; set; }
        public string UserIdCode { get; set; }
    }
}
