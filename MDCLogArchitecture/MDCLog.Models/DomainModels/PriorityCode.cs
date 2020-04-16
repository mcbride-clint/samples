using MDCLogArchitecture.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MDCLogArchitecture.Models.DomainModels
{
    public class PriorityCode : IPriorityCode
    {
        public string Priority { get; set; }
        public string Descr { get; set; }
    }
}
