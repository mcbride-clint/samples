using System;
using System.Collections.Generic;
using System.Text;
using MDCLogArchitecture.Models.DomainModels;



namespace MDCLogArchitecture.Domain.Interfaces.Repositories
{
    public interface IPriorityRepository
    {
        PriorityCode InsertPriority(PriorityCode entity);
        PriorityCode SavePriority(PriorityCode entity);
        PriorityCode EditPriority(PriorityCode entity);
        PriorityCode FindPriority(string PriorityCode);
        
        IEnumerable<PriorityCode> FindPriorityList();
        PriorityCode DeletePriority(string PriorityCode);
        
    }
}
