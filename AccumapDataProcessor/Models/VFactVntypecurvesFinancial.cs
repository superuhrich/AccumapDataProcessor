using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class VFactVntypecurvesFinancial
    {
        public string? EntityKey { get; set; }
        public int? ActivityDateKey { get; set; }
        public string? AccountKey { get; set; }
        public string? ReserveCategoryKey { get; set; }
        public string? ScenarioKey { get; set; }
        public string? GrossNetKey { get; set; }
        public string? NormalizedTimeKey { get; set; }
        public int? NormalizedMonthKey { get; set; }
        public int? NormalizedDayKey { get; set; }
        public int? ReserveRealizedDateKey { get; set; }
        public double? Cad { get; set; }
        public double? KCad { get; set; }
        public int? NumberOfDays { get; set; }
    }
}
