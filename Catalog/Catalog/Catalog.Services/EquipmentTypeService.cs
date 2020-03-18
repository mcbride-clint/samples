using Catalog.Models.DataTransferObjects;
using Catalog.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Catalog.Services
{
    public class EquipmentTypeService
    {
        private readonly IEquipmentTypeRepository _equipmentTypeRepo;
        private readonly IEquipmentSubTypeRepository _equipmentSubTypeRepo;

        public EquipmentTypeService(
            IEquipmentTypeRepository equipmentTypeRepo,
            IEquipmentSubTypeRepository equipmentSubTypeRepo)
        {
            _equipmentTypeRepo = equipmentTypeRepo;
            _equipmentSubTypeRepo = equipmentSubTypeRepo;
        }

        public IEnumerable<EquipmentTypeGroup> GetAll()
        {
            return from types in _equipmentTypeRepo.Find()
                   join subTypes in _equipmentSubTypeRepo.Find()
                   on types.EquipmentTypeId equals subTypes.ParentEquipmentTypeId into typeGroup
                   select new EquipmentTypeGroup()
                   {
                       EquipmentType = types,
                       SubTypes = typeGroup
                   };

        }
    }
}
