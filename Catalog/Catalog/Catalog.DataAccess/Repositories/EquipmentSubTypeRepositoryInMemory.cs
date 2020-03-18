using Catalog.Models.DomainModels;
using Catalog.Models.Filters;
using Catalog.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Catalog.DataAccess.Repositories
{
    public class EquipmentSubTypeRepositoryInMemory : IEquipmentSubTypeRepository
    {
        private readonly List<EquipmentSubType> EquipmentSubTypes;

        public EquipmentSubTypeRepositoryInMemory()
        {
            // Populate Initial Values
            EquipmentSubTypes = new List<EquipmentSubType>()
            {
                new EquipmentSubType(){
                     EquipmentSubTypeId = 1,
                     Name = "Large Assembly",
                     ParentEquipmentTypeId = 1,
                     Description = "Really Big Stuff"
                },
                new EquipmentSubType(){
                     EquipmentSubTypeId = 2,
                     Name = "Medium Assembly",
                     ParentEquipmentTypeId = 1,
                     Description = "Kinda Big Stuff"
                },
                new EquipmentSubType(){
                     EquipmentSubTypeId = 3,
                     Name = "Circuit Board",
                     ParentEquipmentTypeId = 2,
                     Description = "Holds Electronics"
                },
                new EquipmentSubType(){
                     EquipmentSubTypeId = 4,
                     Name = "Cable",
                     ParentEquipmentTypeId = 2,
                     Description = "Connects Electronics"
                }
            };
        }

        public EquipmentSubType Find(long equipmentSubTypeId)
        {
            return EquipmentSubTypes.Single(d => d.EquipmentSubTypeId == equipmentSubTypeId);
        }

        public IEnumerable<EquipmentSubType> Find()
        {
            return EquipmentSubTypes.AsEnumerable();
        }

        public EquipmentSubType Insert(EquipmentSubType entity)
        {
            entity.EquipmentSubTypeId = EquipmentSubTypes.Max(d => d.EquipmentSubTypeId) + 1;

            EquipmentSubTypes.Add(entity);

            return entity;
        }

        public EquipmentSubType Update(EquipmentSubType entity)
        {
            // Could also replace the values in the existing one
            var existing = EquipmentSubTypes.Single(d => d.EquipmentSubTypeId == entity.EquipmentSubTypeId);
            EquipmentSubTypes.Remove(existing);
            EquipmentSubTypes.Add(entity);

            return entity;
        }

        public void Delete(EquipmentSubType entity)
        {
            var existing = EquipmentSubTypes.Single(d => d.EquipmentSubTypeId == entity.EquipmentSubTypeId);
            EquipmentSubTypes.Remove(existing);
        }
    }
}
