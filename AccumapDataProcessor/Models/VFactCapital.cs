using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class VFactCapital
    {
        public string? AfeKey { get; set; }
        public string? EntityKey { get; set; }
        public string? AccountKey { get; set; }
        public int? AccountingPeriodKey { get; set; }
        public int? ActivityPeriodKey { get; set; }
        public int? GrossNetKey { get; set; }
        public int? VendorKey { get; set; }
        public string? ScenarioKey { get; set; }
        public string? OpNonop { get; set; }
        public int? CcCreationDateKey { get; set; }
        public int? AfeTerminationDateKey { get; set; }
        public int? OnProductionDateKey { get; set; }
        public int? SpudDateKey { get; set; }
        public int? RigReleaseDateKey { get; set; }
        public int? CcTerminationDateKey { get; set; }
        public string? BudgetGroup { get; set; }
        public string? AfeType { get; set; }
        public double? CdnDollars { get; set; }
        public double? UsDollars { get; set; }
        public decimal? WorkingInterest { get; set; }
    }
}
