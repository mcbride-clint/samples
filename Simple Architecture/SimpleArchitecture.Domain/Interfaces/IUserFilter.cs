using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleArchitecture.Domain.Interfaces
{
    public interface IUserFilter
    {
        long? UserIdSeqNum { get; set; }
        string UserId { get; set; }
        string FullName { get; set; }
        string Activity { get; set; }
        string Subactivity { get; set; }
        string Owner { get; set; }
    }
}
