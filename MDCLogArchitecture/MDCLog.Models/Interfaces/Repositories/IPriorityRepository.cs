using System;
using System.Collections.Generic;
using System.Text;
using MDCLogArchitecture.Models.DomainModels;

namespace MDCLogArchitecture.Models.Interfaces.Repositories
{
    public interface IPriorityRepository
    {
        PriorityCode InsertPriority(PriorityCode entity);
        PriorityCode SavePriority(PriorityCode entity);
        PriorityCode EditPriority(PriorityCode entity);
        PriorityCode FindPriority(string PriorityCode);
        List<PriorityCode> FindPriorityList();
        PriorityCode DeletePriority(string PriorityCode);
    }
}
