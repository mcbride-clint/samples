using Catalog.Models.DomainModels;
using Catalog.Models.Filters;
using System.Collections.Generic;

namespace Catalog.Models.Interfaces
{
    public interface IDesignatorRepository
    {
        void Delete(Designator entity);
        IEnumerable<Designator> Find(DesignatorFilter filter);
        Designator Find(long designatorId);
        Designator Insert(Designator entity);
        Designator Update(Designator entity);
    }
}