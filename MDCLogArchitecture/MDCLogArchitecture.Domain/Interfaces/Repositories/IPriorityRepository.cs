using System.Collections.Generic;
using MDCLogArchitecture.Models.DomainModels;
using MDCLogArchitecture.Models.ViewModels;


namespace MDCLogArchitecture.Domain.Interfaces.Repositories
{
    public interface IPriorityRepository
    {
        PriorityCodeVM InsertPriority(PriorityCodeVM ThisPriorityCode);
        PriorityCode SavePriority(PriorityCode entity);
        PriorityCodeVM EditPriority(PriorityCodeVM entity);
        PriorityCodeVM FindPriority(int Priority);
        IEnumerable<PriorityCode> FindPriorityList();
        //PriorityCode DeletePriority(string PriorityCode);
        int DeletePriority(int Priority);

    }
}

