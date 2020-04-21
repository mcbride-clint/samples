using System;
using System.Collections.Generic;
using System.Text;

namespace MDCLogArchitecture.Domain.Interfaces
{
    public interface IPriorityCode
    {
         string Priority { get; set; }
         string Descr { get; set; }
    }
}
