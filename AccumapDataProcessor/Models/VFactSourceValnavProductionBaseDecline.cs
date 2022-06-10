using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class VFactSourceValnavProductionBaseDecline
    {
        public string? EntityId { get; set; }
        public DateTime StepDate { get; set; }
        public int? ProductId { get; set; }
        public double GrossVolumeImp { get; set; }
        public double? GrossVolumeMet { get; set; }
        public double? GrossVolumeBoe { get; set; }
        public double? GrossVolumeMcfe { get; set; }
        public double WiVolumeImp { get; set; }
        public double? WiVolumeMet { get; set; }
        public double? WiVolumeBoe { get; set; }
        public double? WiVolumeMcfe { get; set; }
        public double RiVolumeImp { get; set; }
        public double? RiVolumeMet { get; set; }
        public double? RiVolumeBoe { get; set; }
        public double? RiVolumeMcfe { get; set; }
        public double? FiVolumeImp { get; set; }
        public double? FiVolumeMet { get; set; }
        public double? FiVolumeBoe { get; set; }
        public double? FiVolumeMcfe { get; set; }
        public string? FormattedId { get; set; }
        public string? Uwi { get; set; }
        public string? ReserveCategoryId { get; set; }
        public string Accounts { get; set; } = null!;
        public string ScenarioType { get; set; } = null!;
        public string? Scenario { get; set; }
        public decimal? SiToImpConvFactor { get; set; }
        public decimal? BoeThermal { get; set; }
        public decimal? Mcfe6Thermal { get; set; }
        public DateTime? OnstreamDate { get; set; }
        public string? NormalizedTimeKey { get; set; }
    }
}
