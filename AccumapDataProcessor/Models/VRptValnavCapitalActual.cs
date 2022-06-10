using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class VRptValnavCapitalActual
    {
        public string EntityId { get; set; } = null!;
        public string? RegionName { get; set; }
        public string? DistrictName { get; set; }
        public string? AreaName { get; set; }
        public string? FacilityName { get; set; }
        public string? CostCentre { get; set; }
        public string Uwi { get; set; } = null!;
        public string? FormattedUwi { get; set; }
        public DateTime? CostDate { get; set; }
        public double? Value { get; set; }
        public string? AfeNum { get; set; }
        public string? CostType { get; set; }
        public double? ApprovedEstimate { get; set; }
        public double? RevisedEstimate { get; set; }
        public DateTime? EndDate { get; set; }
        public double? IncurredTotal { get; set; }
    }
}
