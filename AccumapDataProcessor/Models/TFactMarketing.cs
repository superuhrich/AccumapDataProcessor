using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TFactMarketing
    {
        public string? FlownetId { get; set; }
        public string? FlownetName { get; set; }
        public string? ChildIdrec { get; set; }
        public string? UwiName { get; set; }
        public string? CcNum { get; set; }
        public string? SalesDispositionPoint { get; set; }
        public string? MeterName { get; set; }
        public string? Typ { get; set; }
        public string PartnerName { get; set; } = null!;
        public DateTime? ActivityDate { get; set; }
        public string? ActivityYearMonth { get; set; }
        public double? RawVolume { get; set; }
        public double? SalesVolume { get; set; }
        public double? AllocatedVolume { get; set; }
    }
}
