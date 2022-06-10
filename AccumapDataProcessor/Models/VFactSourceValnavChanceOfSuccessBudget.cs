using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class VFactSourceValnavChanceOfSuccessBudget
    {
        public string EntityKey { get; set; } = null!;
        public int ReserveCategoryId { get; set; }
        public string Accounts { get; set; } = null!;
        public string ScenarioType { get; set; } = null!;
        public string? Scenario { get; set; }
        public string GrsNet { get; set; } = null!;
        public int? ActivityDateKey { get; set; }
        public string NormalizedTimeKey { get; set; } = null!;
        public double ChanceOfSuccess { get; set; }
    }
}
