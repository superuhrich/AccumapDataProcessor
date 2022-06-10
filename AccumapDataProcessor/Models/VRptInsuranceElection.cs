using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class VRptInsuranceElection
    {
        public string? CcTypeCode { get; set; }
        public string? CostCentreId { get; set; }
        public string? CostCentreName { get; set; }
        public string? LicenseNo { get; set; }
        public decimal? WorkingInterestPct { get; set; }
        public decimal? OperatorId { get; set; }
        public string? OperatorName { get; set; }
        public string? OpNonop { get; set; }
        public string? InsuranceElection { get; set; }
    }
}
