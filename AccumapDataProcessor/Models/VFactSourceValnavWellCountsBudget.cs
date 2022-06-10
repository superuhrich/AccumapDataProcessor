using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class VFactSourceValnavWellCountsBudget
    {
        public string EntityKey { get; set; } = null!;
        public string? Uwi { get; set; }
        public DateTime? ActvyDate { get; set; }
        public int? ActivityDateKey { get; set; }
        public string? Accounts { get; set; }
        public int ReserveCategoryId { get; set; }
        public string? Scenario { get; set; }
        public string? ScenarioType { get; set; }
        public string? GrsNet { get; set; }
        public double? Cad { get; set; }
        public double? KCad { get; set; }
        public string? CapitalType { get; set; }
    }
}
