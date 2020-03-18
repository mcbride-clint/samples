using Catalog.Models.DomainModels;
using Catalog.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Catalog.DataAccess.Repositories
{
    public class EquipmentTypeRepositoryInMemory : IEquipmentTypeRepository
    {
        private readonly List<EquipmentType> EquipmentTypes;

        public EquipmentTypeRepositoryInMemory()
        {
            // Populate Initial Values
            EquipmentTypes = new List<EquipmentType>()
            {
                new EquipmentType(){
                     EquipmentTypeId = 1,
                     Name = "Infrastructure",
                     Description = "Holds up alot"
                },
                new EquipmentType(){
                     EquipmentTypeId = 2,
                     Name = "Other",
                     Description = "Miscellaneous Items"
                }
            };
        }

        public EquipmentType Find(long equipmentTypeId)
        {
            return EquipmentTypes.Single(d => d.EquipmentTypeId == equipmentTypeId);
        }

        public IEnumerable<EquipmentType> Find()
        {
            return EquipmentTypes;
        }

        public EquipmentType Insert(EquipmentType entity)
        {
            entity.EquipmentTypeId = EquipmentTypes.Max(d => d.EquipmentTypeId) + 1;

            EquipmentTypes.Add(entity);

            return entity;
        }

        public EquipmentType Update(EquipmentType entity)
        {
            // Could also replace the values in the existing one
            var existing = EquipmentTypes.Single(d => d.EquipmentTypeId == entity.EquipmentTypeId);
            EquipmentTypes.Remove(existing);
            EquipmentTypes.Add(entity);

            return entity;
        }

        public void Delete(EquipmentType entity)
        {
            var existing = EquipmentTypes.Single(d => d.EquipmentTypeId == entity.EquipmentTypeId);
            EquipmentTypes.Remove(existing);
        }
    }
}
