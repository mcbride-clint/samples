using Catalog.Models.DomainModels;
using Catalog.Models.Filters;
using System.Collections.Generic;

namespace Catalog.Models.Interfaces
{
    public interface IEquipmentTypeRepository
    {
        void Delete(EquipmentType entity);
        IEnumerable<EquipmentType> Find();
        EquipmentType Find(long designatorId);
        EquipmentType Insert(EquipmentType entity);
        EquipmentType Update(EquipmentType entity);
    }
}