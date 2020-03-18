using System;
using System.Collections.Generic;
using System.Text;

namespace Catalog.Models.Filters
{
    public class EquipmentSubTypeFilter
    {
        public int? EquipmentSubTypeId { get; set; }
        public int? ParentEquipmentTypeId { get; set; }
    }
}
