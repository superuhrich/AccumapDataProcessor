using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TDimNormalizedTime1
    {
        public string? NormalizedTimeKey { get; set; }
        public int? DayNumber { get; set; }
        public string DayName { get; set; } = null!;
        public int? WeekNumber { get; set; }
        public string? WeekName { get; set; }
        public string? MonthName { get; set; }
        public string? DayName2 { get; set; }
    }
}
