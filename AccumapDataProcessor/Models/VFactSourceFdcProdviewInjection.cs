using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class VFactSourceFdcProdviewInjection
    {
        public string? SiteId { get; set; }
        public int? ActivityDateKey { get; set; }
        public string? EntityKey { get; set; }
        public string DataType { get; set; } = null!;
        public string ScenarioKey { get; set; } = null!;
        public int GrossNetKey { get; set; }
        public double? InjectedProdWater { get; set; }
        public double? InjectedSrcWater { get; set; }
        public double? InjectedGasC02 { get; set; }
        public double? InjectedPressureKpag { get; set; }
    }
}
