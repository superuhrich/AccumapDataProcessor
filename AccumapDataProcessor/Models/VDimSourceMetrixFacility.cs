using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class VDimSourceMetrixFacility
    {
        public decimal FacilitySysId { get; set; }
        public string EntityId { get; set; } = null!;
        public string EntityTypeCode { get; set; } = null!;
        public string? EntityType { get; set; }
        public string Province { get; set; } = null!;
        public string? FacilityId { get; set; }
        public string? FacilityName { get; set; }
        public string? FacilityGovernmentCode { get; set; }
        public string? FacilityCostCentreCode { get; set; }
        public string? FacilityProductionStatus { get; set; }
        public string? FacilityOperatorId { get; set; }
        public string? FacilityOperatorName { get; set; }
        public string? FacilityPaResponsibleUserId { get; set; }
        public string? FacilityPaResponsibleUser { get; set; }
        public string? FacilityCode { get; set; }
    }
}
