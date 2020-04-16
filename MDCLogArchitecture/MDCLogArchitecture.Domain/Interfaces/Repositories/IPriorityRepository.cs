using System;
using System.Collections.Generic;
using System.Text;
using MDCLogArchitecture.Models.DomainModels;
using MDCLogArchitecture.Models.Filters;

namespace MDCLogArchitecture.Domain.Interfaces.Repositories
{
    public interface IPriorityRepository
    {
        IPriorityCode InsertPriority(IPriorityCode entity);
        IPriorityCode SavePriority(IPriorityCode entity);
        IPriorityCode EditPriority(IPriorityCode entity);
        IPriorityCode FindPriority(IPriorityCodesFilter filter);
        
        IEnumerable<IPriorityCode> FindPriorityList(PriorityCodesFilter filter);
        IPriorityCode DeletePriority(string PriorityCode);
        
    }
}
