using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class VFactSourceQbyteIncr
    {
        public decimal? LiId { get; set; }
        public decimal? VoucherId { get; set; }
        public string? EntityKey { get; set; }
        public string? AfeKey { get; set; }
        public int? AccountingMonthKey { get; set; }
        public int? ActivityMonthKey { get; set; }
        public decimal? OrganizationKey { get; set; }
        public int? GrossNetKey { get; set; }
        public string? AccountKey { get; set; }
        public string ScenarioKey { get; set; } = null!;
        public decimal VendorKey { get; set; }
        public decimal? Cad { get; set; }
        public decimal? QbCad { get; set; }
        public decimal? Usd { get; set; }
        public decimal? QbMetricVolume { get; set; }
        public decimal? MetricVolume { get; set; }
        public decimal? QbImperialVolume { get; set; }
        public decimal? ImperialVolume { get; set; }
        public decimal? QbBoeVolume { get; set; }
        public decimal? BoeVolume { get; set; }
        public decimal? QbMcfeVolume { get; set; }
        public decimal? McfeVolume { get; set; }
        public decimal? CadFixed { get; set; }
        public decimal? CadVariable { get; set; }
        public decimal? CadEconFixed { get; set; }
        public decimal? CadEconVariableGas { get; set; }
        public decimal? CadEconVariableOil { get; set; }
        public int? IsLeaseops { get; set; }
        public int IsCapital { get; set; }
        public int IsVolumes { get; set; }
        public int IsValnav { get; set; }
        public int IsFinance { get; set; }
    }
}
