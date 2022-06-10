using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class VDimSourceFacility
    {
        public decimal FacilitySysId { get; set; }
        public string? FacilityId { get; set; }
        public string? FacilityName { get; set; }
        public string? FacilityTypeCode { get; set; }
        public string? FacilityTypeDesc { get; set; }
        public string? FacilityProvince { get; set; }
        public string? FacilityGovernmentCode { get; set; }
        public string? FacilityCostCentreCode { get; set; }
        public string? FacilityProductionStatus { get; set; }
        public string? FacilityOperatorId { get; set; }
        public string? FacilityOperatorName { get; set; }
        public string? FacilityPaResponsibleUserId { get; set; }
        public string? FacilityPaResponsibleUser { get; set; }
        public string? FacilityCode { get; set; }
        public string? RegistryFacilityName { get; set; }
        public string? RegistryOperatorName { get; set; }
    }
}
