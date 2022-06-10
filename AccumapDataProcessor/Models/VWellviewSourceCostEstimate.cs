using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class VWellviewSourceCostEstimate
    {
        public string? AfeNum { get; set; }
        public string AfeSupp { get; set; } = null!;
        public DateTime? TimePeriod { get; set; }
        public DateTime? StartDate { get; set; }
        public string WvAfeType { get; set; } = null!;
        public string GrsNetFlag { get; set; } = null!;
        public string? GlNetAccount { get; set; }
        public string? MajorAcct { get; set; }
        public string? MinorAcct { get; set; }
        public string Scenario { get; set; } = null!;
        public double? Amount { get; set; }
        public string? MajClassCode { get; set; }
        public string IsValidQbyteMajor { get; set; } = null!;
        public string IsValidAfe { get; set; } = null!;
        public string? Vendorcode { get; set; }
    }
}
