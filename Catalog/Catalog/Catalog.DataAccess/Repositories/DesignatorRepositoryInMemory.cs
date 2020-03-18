using Catalog.Models.DomainModels;
using Catalog.Models.Filters;
using Catalog.Models.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Catalog.DataAccess.Repositories
{
    public class DesignatorRepositoryInMemory : IDesignatorRepository
    {
        private readonly List<Designator> Designators;

        public DesignatorRepositoryInMemory()
        {
            // Populate Initial Values
            Designators = new List<Designator>()
            {
                new Designator(){
                    DesignatorId = 1,
                    ActivityId = 1,
                    EquipmentTypeId = 1,
                    EquipmentSubType = 1,
                    Nomenclature = "Test Category",
                    LeadTimeGroupId = 1,
                    OwnerId = 1,
                    SubActivityId = 1,
                    IsAssembly = true,
                    IsComponent = true,
                    IsSpare = true
                }
            };
        }

        public Designator Find(long designatorId)
        {
            return Designators.Single(d => d.DesignatorId == designatorId);
        }

        public IEnumerable<Designator> Find(DesignatorFilter filter)
        {
            var matchedDesignators = Designators.AsEnumerable();

            if (filter.IsAssembly)
            {
                matchedDesignators = matchedDesignators.Where(d => d.IsAssembly);
            }
            if (filter.IsComponent)
            {
                matchedDesignators = matchedDesignators.Where(d => d.IsComponent);
            }
            if (filter.IsSpare)
            {
                matchedDesignators = matchedDesignators.Where(d => d.IsSpare);
            }
            if (filter.DesignatorId.HasValue)
            {
                matchedDesignators = matchedDesignators.Where(d => d.DesignatorId == filter.DesignatorId);
            }
            if (filter.ActivityId.HasValue)
            {
                matchedDesignators = matchedDesignators.Where(d => d.ActivityId == filter.ActivityId);
            }
            if (filter.SubActivityId.HasValue)
            {
                matchedDesignators = matchedDesignators.Where(d => d.SubActivityId == filter.SubActivityId);
            }
            if (filter.OwnerId.HasValue)
            {
                matchedDesignators = matchedDesignators.Where(d => d.OwnerId == filter.OwnerId);
            }
            if (filter.LeadTimeGroupId.HasValue)
            {
                matchedDesignators = matchedDesignators.Where(d => d.LeadTimeGroupId == filter.LeadTimeGroupId);
            }
            if (filter.EquipmentTypeId.HasValue)
            {
                matchedDesignators = matchedDesignators.Where(d => d.EquipmentTypeId == filter.EquipmentTypeId);
            }
            if (filter.EquipmentSubType.HasValue)
            {
                matchedDesignators = matchedDesignators.Where(d => d.EquipmentSubType == filter.EquipmentSubType);
            }

            return matchedDesignators;
        }

        public Designator Insert(Designator entity)
        {
            entity.DesignatorId = Designators.Max(d => d.DesignatorId) + 1;

            Designators.Add(entity);

            return entity;
        }

        public Designator Update(Designator entity)
        {
            // Could also replace the values in the existing one
            var existing = Designators.Single(d => d.DesignatorId == entity.DesignatorId);
            Designators.Remove(existing);
            Designators.Add(entity);

            return entity;
        }

        public void Delete(Designator entity)
        {
            var existing = Designators.Single(d => d.DesignatorId == entity.DesignatorId);
            Designators.Remove(existing);
        }
    }
}