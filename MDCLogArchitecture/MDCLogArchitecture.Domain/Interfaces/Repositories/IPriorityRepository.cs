using System;
using System.Collections.Generic;
using System.Text;



namespace MDCLogArchitecture.Domain.Interfaces.Repositories
{
    public interface IPriorityRepository
    {
        IPriorityCode InsertPriority(IPriorityCode entity);
        IPriorityCode SavePriority(IPriorityCode entity);
        IPriorityCode EditPriority(IPriorityCode entity);
        IPriorityCode FindPriority(string PriorityCode);
        
        IEnumerable<IPriorityCode> FindPriorityList();
        IPriorityCode DeletePriority(string PriorityCode);
        
    }
}
