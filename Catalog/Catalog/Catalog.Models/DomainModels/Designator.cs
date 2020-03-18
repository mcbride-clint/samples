using System;
using System.Collections.Generic;
using System.Text;

namespace Catalog.Models.DomainModels
{
    public class Designator
    {
        public long DesignatorId { get; set; }
        public bool IsAssembly { get; set; }
        public bool IsComponent { get; set; }
        public bool IsSpare { get; set; }
        public string Nomenclature { get; set; }
        public int EquipmentTypeId { get; set; }
        public int EquipmentSubType { get; set; }
        public int LeadTimeGroupId { get; set; }
        public int ActivityId { get; set; }
        public int SubActivityId { get; set; }
        public int OwnerId { get; set; }
        public IEnumerable<int> ImageIds { get; set; }
    }
}
