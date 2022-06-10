using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class VDimDateAccountingFinance
    {
        public int? DateKey { get; set; }
        public string? FullDate { get; set; }
        public string? CalendarMonthName { get; set; }
        public string? CalendarQuarterName { get; set; }
        public string? CalendarYearName { get; set; }
        public int? NumberOfDays { get; set; }
    }
}
