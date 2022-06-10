using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class VExceptionVolumesVsValnavUwiCostCentre
    {
        public string? EntityKey { get; set; }
        public string? EntityName { get; set; }
        public string? VolumesCostCentre { get; set; }
        public string? VolumesCostCentreName { get; set; }
        public string? ValnavCostCentre { get; set; }
        public string? ValnavCostCentreName { get; set; }
        public string? VolumesUwiSource { get; set; }
    }
}
