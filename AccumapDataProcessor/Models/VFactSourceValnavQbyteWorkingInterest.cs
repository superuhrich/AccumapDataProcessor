using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class VFactSourceValnavQbyteWorkingInterest
    {
        public string? EntityKey { get; set; }
        public int ActivityDateKey { get; set; }
        public string AccountKey { get; set; } = null!;
        public int ReserveCategoryKey { get; set; }
        public string? ScenarioKey { get; set; }
        public string NormalizedTimeKey { get; set; } = null!;
        public string GrossNetKey { get; set; } = null!;
        public string? ScenarioType { get; set; }
        public decimal? WorkingInterest { get; set; }
    }
}
