using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleArchitecture.BlazorDevExpress.ViewModel
{
    public class UserVM
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
