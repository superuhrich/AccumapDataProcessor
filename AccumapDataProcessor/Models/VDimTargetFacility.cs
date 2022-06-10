using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class VDimTargetFacility
    {
        public string? TargetFacilityId { get; set; }
        public string? TargetFacilityName { get; set; }
        public string? TargetFacilityGovernmentCode { get; set; }
        public string? TargetFacilityProvince { get; set; }
        public string? TargetFacilityOperatorId { get; set; }
        public string? TargetFacilityOperatorName { get; set; }
        public string? FacilityTypeCode { get; set; }
        public string? FacilityTypeDesc { get; set; }
        public string? FacilityCode { get; set; }
        public string? RegistryFacilityName { get; set; }
        public string? RegistryOperatorName { get; set; }
    }
}
