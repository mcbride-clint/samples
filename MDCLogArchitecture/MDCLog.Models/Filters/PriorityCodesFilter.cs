using System;
using System.Collections.Generic;
using System.Text;
using MDCLogArchitecture.Domain.Interfaces;

namespace MDCLogArchitecture.Models.Filters
{
    public class PriorityCodesFilter : IPriorityCodesFilter
    {
        
        public int? Priority { get; set; }
        public string Descr { get; set; }
        

    }
   
}
