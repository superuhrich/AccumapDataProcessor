using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class VOpexBudgetSourceFact
    {
        public string? EntityKey { get; set; }
        public string AccountKey { get; set; } = null!;
        public int? AccountingMonthKey { get; set; }
        public int? ActivityMonthKey { get; set; }
        public int GrossNetKey { get; set; }
        public int VendorKey { get; set; }
        public string ScenarioKey { get; set; } = null!;
        public int SpudDateKey { get; set; }
        public int RigReleaseDateKey { get; set; }
        public int OnProductionDateKey { get; set; }
        public int CcCreateDateKey { get; set; }
        public int CcTermDateKey { get; set; }
        public double? Cad { get; set; }
        public double? Usd { get; set; }
        public double? MetricVolume { get; set; }
        public double? ImperialVolume { get; set; }
        public double? BoeVolume { get; set; }
        public double? McfeVolume { get; set; }
        public double? CadFixed { get; set; }
        public double? CadVariable { get; set; }
        public double? CadEconFixed { get; set; }
        public double? CadEconVariableGas { get; set; }
        public double? CadEconVariableOil { get; set; }
        public int IsLeaseops { get; set; }
    }
}
