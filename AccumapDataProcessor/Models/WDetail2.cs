using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class WDetail2
    {
        public string FileNumber { get; set; } = null!;
        public string? ContractOperator { get; set; }
        public string? Reserve { get; set; }
        public string? Facility { get; set; }
        public string? Field { get; set; }
        public string? Pool { get; set; }
        public string? LicenceNumber { get; set; }
        public DateTime? LicenceDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public string? SurfaceLocation { get; set; }
        public decimal? Metes { get; set; }
        public string? MetesDirection { get; set; }
        public decimal? Bounds { get; set; }
        public string? BoundsDirection { get; set; }
        public string? LaheeClass { get; set; }
        public decimal? Dsu { get; set; }
        public string? DsuUom { get; set; }
        public string? AccountingProject { get; set; }
        public decimal? ProjectedDepth { get; set; }
        public decimal? TotalDepth { get; set; }
        public decimal? TrueVertDepth { get; set; }
        public decimal? PlugBackDepth { get; set; }
        public decimal? GroundElevation { get; set; }
        public decimal? KellyBushingElev { get; set; }
        public string? UnitOfMeasure { get; set; }
        public string? TotalDepthZone { get; set; }
        public string ProducingZone { get; set; } = null!;
        public string? TargetZone { get; set; }
        public string? GovtUnitCode { get; set; }
    }
}
