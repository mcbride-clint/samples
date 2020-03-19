using Catalog.Models.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Catalog.DataAccess.Repositories
{
    public class LeadTimeGroupRepository
    {
        private readonly List<LeadTimeGroup> LeadTimeGroups;

        public LeadTimeGroupRepository()
        {
            LeadTimeGroups = new List<LeadTimeGroup>();

            LeadTimeGroups.Add(new LeadTimeGroup()
            {
                 LeadTimeGroupId = 1,
                 Name = "Long",
                 Description = "More Than 5 Years"
            });

            LeadTimeGroups.Add(new LeadTimeGroup()
            {
                LeadTimeGroupId = 2,
                Name = "Short",
                Description = "Less Than 5 Years"
            });
        }

        public LeadTimeGroup Find(int leadTimeGroupId)
        {
            return LeadTimeGroups.SingleOrDefault(ltg => ltg.LeadTimeGroupId == leadTimeGroupId);
        }

        public IEnumerable<LeadTimeGroup> Find()
        {
            return LeadTimeGroups;
        }

        public LeadTimeGroup Insert(LeadTimeGroup entity)
        {
            entity.LeadTimeGroupId = LeadTimeGroups.Max(ltg => ltg.LeadTimeGroupId);

            LeadTimeGroups.Add(entity);

            return entity;
        }

        public LeadTimeGroup Update(LeadTimeGroup entity)
        {
            var existingItem = LeadTimeGroups.Single(ltg => ltg.LeadTimeGroupId == entity.LeadTimeGroupId);
            existingItem.Name = entity.Name;
            existingItem.Description = entity.Description;

            return existingItem;
        }

        public void Delete(int leadTimeGroupId)
        {
            var existingItem = LeadTimeGroups.Single(ltg => ltg.LeadTimeGroupId == leadTimeGroupId);
            LeadTimeGroups.Remove(existingItem);
        }
    }
}
