using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class VFactSourceValnavReservesTypecurf
    {
        public string? EntityGuid { get; set; }
        public DateTime? BookedDate { get; set; }
        public int ProductId { get; set; }
        public double TechGrossVolume { get; set; }
        public double TechWiVolume { get; set; }
        public double? GrossVolumeMet { get; set; }
        public double? GrossVolumeBoe { get; set; }
        public double? GrossVolumeMcfe { get; set; }
        public double? WiVolumeMet { get; set; }
        public double? WiVolumeBoe { get; set; }
        public double? WiVolumeMcfe { get; set; }
        public string? EntityId { get; set; }
        public string? FormattedId { get; set; }
        public string? Uwi { get; set; }
        public int? ReserveCategoryId { get; set; }
        public string Accounts { get; set; } = null!;
        public string ScenarioType { get; set; } = null!;
        public string? Scenario { get; set; }
        public decimal? SiToImpConvFactor { get; set; }
        public decimal? BoeThermal { get; set; }
        public decimal? Mcfe6Thermal { get; set; }
    }
}
