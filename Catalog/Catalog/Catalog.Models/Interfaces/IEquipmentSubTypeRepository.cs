using Catalog.Models.DomainModels;
using Catalog.Models.Filters;
using System.Collections.Generic;

namespace Catalog.Models.Interfaces
{
    public interface IEquipmentSubTypeRepository
    {
        void Delete(EquipmentSubType entity);
        IEnumerable<EquipmentSubType> Find();
        EquipmentSubType Find(long equipmentSubTypeId);
        EquipmentSubType Insert(EquipmentSubType entity);
        EquipmentSubType Update(EquipmentSubType entity);
    }
}