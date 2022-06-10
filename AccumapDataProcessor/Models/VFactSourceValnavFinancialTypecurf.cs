using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class VFactSourceValnavFinancialTypecurf
    {
        public string? EntityKey { get; set; }
        public int? ActivityDateKey { get; set; }
        public string? AccountKey { get; set; }
        public int? ReserveCategoryKey { get; set; }
        public string? ScenarioKey { get; set; }
        public string GrossNetKey { get; set; } = null!;
        public string? NormalizedTimeKey { get; set; }
        public string? ScenarioType { get; set; }
        public double? Cad { get; set; }
        public double? KCad { get; set; }
    }
}
