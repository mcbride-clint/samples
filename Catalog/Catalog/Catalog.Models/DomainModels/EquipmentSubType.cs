using System;
using System.Collections.Generic;
using System.Text;

namespace Catalog.Models.DomainModels
{
    public class EquipmentSubType
    {
        public int EquipmentSubTypeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int ParentEquipmentTypeId { get; set; }
    }
}
