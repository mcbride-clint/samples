using Catalog.Models.DomainModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Catalog.Models.DataTransferObjects
{
    public class EquipmentTypeGroup
    {
        public EquipmentType EquipmentType { get; set; }
        public IEnumerable<EquipmentSubType> SubTypes { get; set; }
    }
}
