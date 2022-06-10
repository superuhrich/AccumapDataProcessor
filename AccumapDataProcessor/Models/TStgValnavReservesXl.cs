using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TStgValnavReservesXl
    {
        public string? SourceFile { get; set; }
        public string? ReserveCategory { get; set; }
        public string? CcNum { get; set; }
        public string? Uwi { get; set; }
        public string? Accounts { get; set; }
        public string? Scenario { get; set; }
        public string? AccountingMonth { get; set; }
        public string? ReservesProperty { get; set; }
        public string? ZonePlay { get; set; }
        public double? Amount { get; set; }
    }
}
