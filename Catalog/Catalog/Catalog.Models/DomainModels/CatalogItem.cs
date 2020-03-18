using System;
using System.Collections.Generic;
using System.Text;

namespace Catalog.Models.DomainModels
{
    public class CatalogItem
    {
        public long? CatalogItemId { get; set; }
        public long? DesignatorId { get; set; }
        public string Description { get; set; }
        public string Generation { get; set; }
        public long EngineerId { get; set; }
        public long PurchaseGroupId { get; set; }
        public int? LeadTimeMonths { get; set; }
        public decimal? EstimatedPrice { get; set; }
        public string CognizantUnit { get; set; }
        public bool HighestAssembly { get; set; }
        public long ManualId { get; set; }
        public int? ManualChapter { get; set; }
        public long? PartNumberId { get; set; }
        public long? StandardIdentifierId { get; set; }
        public string DrawingNumber { get; set; }
        public string DrawingRevision { get; set; }
        public int? FirstProductionYear { get; set; }
        public int? LastProductionYear { get; set; }
        public string Notes { get; set; }
        public int DesignMaturityId { get; set; }
        public int GenericTypeId { get; set; }
        public IEnumerable<int> ImageIds { get; set; }
    }
}
