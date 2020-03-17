using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleArchitecture.Models.DomainModels
{
    public class User
    {
        public long UserIdSeqNum { get; set; }
        public string UserId { get; set; }
        public string FullName { get; set; }
        public string Activity { get; set; }
        public string Subactivity { get; set; }
        public string Owner { get; set; }
        public string PhoneNumber { get; set; }
    }
}
