using Catalog.Models.DomainModels;
using Catalog.Models.Filters;
using Catalog.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Catalog.DataAccess.Repositories
{
    public class EquipmentSubTypeRepositoryInMemory : IEquipmentSubTypeRepository
    {
        private readonly List<EquipmentSubType> EquipmentSubTypes;

        public EquipmentSubTypeRepositoryInMemory()
        {
            // May Only work in Testing
            var rootDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName;
            var dummyData = File.ReadAllText(rootDirectory + "\\Catalog.DataAccess\\DummyData\\EquipmentSubType.json");
            EquipmentSubTypes = Newtonsoft.Json.JsonConvert.DeserializeObject<List<EquipmentSubType>>(dummyData);          
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
