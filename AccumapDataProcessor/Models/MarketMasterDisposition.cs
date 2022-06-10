using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class MarketMasterDisposition
    {
        public string CreateUser { get; set; } = null!;
        public string? CreateProgram { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string LastUpdateUser { get; set; } = null!;
        public string? LastUpdateProgram { get; set; }
        public DateTime LastUpdateDateTime { get; set; }
        public decimal? LastUpdateAuditId { get; set; }
        public decimal Version { get; set; }
        public decimal SysId { get; set; }
        public decimal ProductionDate { get; set; }
        public decimal DeliverySequence { get; set; }
        public decimal DeliverySystemPriority { get; set; }
        public string SystemGenerated { get; set; } = null!;
        public decimal FacilitySysId { get; set; }
        public decimal? DestinationFacilitySysId { get; set; }
        public string ProductCode { get; set; } = null!;
        public string DispositionTypeCode { get; set; } = null!;
        public string? DestinationDeliverySystemId { get; set; }
    }
}
