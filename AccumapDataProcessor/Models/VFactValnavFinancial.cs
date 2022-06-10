using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class VFactValnavFinancial
    {
        public string? EntityKey { get; set; }
        public int? ActivityDateKey { get; set; }
        public string? AccountKey { get; set; }
        public string? ReserveCategoryKey { get; set; }
        public string? ScenarioKey { get; set; }
        public string? GrossNetKey { get; set; }
        public string? NormalizedTimeKey { get; set; }
        public int? ReserveRealizedDateKey { get; set; }
        public double? Cad { get; set; }
        public double? KCad { get; set; }
        public double? Wi { get; set; }
        public int? NumberOfDays { get; set; }
        public string? EtlStatus { get; set; }
    }
}
