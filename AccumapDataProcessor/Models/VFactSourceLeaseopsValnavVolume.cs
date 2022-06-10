using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class VFactSourceLeaseopsValnavVolume
    {
        public string EntityKey { get; set; } = null!;
        public string? AccountKey { get; set; }
        public int? AccountingMonthKey { get; set; }
        public int? ActivityDateKey { get; set; }
        public int GrossNetKey { get; set; }
        public string VendorKey { get; set; } = null!;
        public string? ScenarioKey { get; set; }
        public int SpudDateKey { get; set; }
        public int RigReleaseDateKey { get; set; }
        public int OnProdDateKey { get; set; }
        public int CcCreateDateKey { get; set; }
        public int CcTermDateKey { get; set; }
        public double? MetricVolume { get; set; }
        public double? ImperialVolume { get; set; }
        public double? BoeVolume { get; set; }
        public double? McfeVolume { get; set; }
    }
}
