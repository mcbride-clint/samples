using Catalog.Models.DomainModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Catalog.Models.Interfaces
{
    public interface ILeadTimeGroupRepository
    {
        void Delete(int leadTimeGroupId);
        IEnumerable<LeadTimeGroup> Find();
        LeadTimeGroup Find(int leadTimeGroupId);
        LeadTimeGroup Insert(LeadTimeGroup entity);
        LeadTimeGroup Update(LeadTimeGroup entity);
    }
}
