using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class VFactSourceValnavLateralLengthBudget
    {
        public string EntityKey { get; set; } = null!;
        public int ActivityDateKey { get; set; }
        public string AccountKey { get; set; } = null!;
        public int ReserveCategoryKey { get; set; }
        public string? ScenarioKey { get; set; }
        public string NormalizedTimeKey { get; set; } = null!;
        public string GrossNetKey { get; set; } = null!;
        public string? ScenarioType { get; set; }
        public double? Cad { get; set; }
    }
}
