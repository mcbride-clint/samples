using System;
using System.Collections.Generic;
using System.Text;
using MDCLogArchitecture.Models.DomainModels;
using MDCLogArchitecture.Models.Filters;

namespace MDCLogArchitecture.Models.Interfaces.Repositories
{
    public interface IPriorityRepository
    {
        PriorityCode InsertPriority(PriorityCode entity);
        PriorityCode SavePriority(PriorityCode entity);
        PriorityCode EditPriority(PriorityCode entity);
        PriorityCode FindPriority(PriorityCodesFilter filter);
        List<PriorityCode> FindPriorityList(PriorityCodesFilter filter);
        PriorityCode DeletePriority(string PriorityCode);
        
    }
}
