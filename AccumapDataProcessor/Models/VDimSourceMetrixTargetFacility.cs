using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class VDimSourceMetrixTargetFacility
    {
        public string? TargetFacilityId { get; set; }
        public string? TargetFacilityName { get; set; }
        public string? TargetFacilityGovernmentCode { get; set; }
        public string TargetFacilityProvince { get; set; } = null!;
        public string? TargetFacilityOperatorId { get; set; }
        public string? TargetFacilityOperatorName { get; set; }
        public string? TargetFacilityRegistryEntityType { get; set; }
        public string EntityTypeCode { get; set; } = null!;
        public string EntityType { get; set; } = null!;
        public string? FacilityCode { get; set; }
    }
}
