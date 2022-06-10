using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class VDimDateRigOnProduction1
    {
        public int DateKey { get; set; }
        public string? FullDate { get; set; }
        public byte? CalendarMonthNumber { get; set; }
        public string? CalendarMonthName { get; set; }
        public byte? CalendarQuarterNumber { get; set; }
        public string? CalendarQuarterName { get; set; }
        public string? CalendarYearNumber { get; set; }
        public string? CalendarYearName { get; set; }
    }
}
