using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class VFactSourceFinanceBudget
    {
        public int? LiId { get; set; }
        public int? VoucherId { get; set; }
        public string? EntityKey { get; set; }
        public string? AccountKey { get; set; }
        public int? AccountingMonthKey { get; set; }
        public int? ActivityMonthKey { get; set; }
        public int? GrossNetKey { get; set; }
        public int? VendorKey { get; set; }
        public string? ScenarioKey { get; set; }
        public int? OrganizationKey { get; set; }
        public string? AfeKey { get; set; }
        public double? Cad { get; set; }
        public double? MetricVolume { get; set; }
        public double? ImperialVolume { get; set; }
        public double? BoeVolume { get; set; }
        public double? McfeVolume { get; set; }
    }
}
