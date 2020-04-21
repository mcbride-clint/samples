using System;
using System.Collections.Generic;
using System.Text;

namespace MDCLogArchitecture.Domain.Interfaces
{
    public interface IPriorityCodesFilter
    {
         int? Priority { get; set; }
         string Descr { get; set; }
    }
}
