using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class VFactSourceValnavEconomicsGljreservesFinal
    {
        public string? EntityKey { get; set; }
        public int? ActivityDateKey { get; set; }
        public int? ReserveCategoryId { get; set; }
        public string? Scenario { get; set; }
        public DateTime? OnstreamDate { get; set; }
        public string? NormalizedTimeKey { get; set; }
        public string GrossNet { get; set; } = null!;
        public string? Accounts { get; set; }
        public double? Cad { get; set; }
        public double? KCad { get; set; }
    }
}
