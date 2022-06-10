using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class VFactSourceLeaseopsOpexAccrual
    {
        public string? EntityKey { get; set; }
        public string? AccountKey { get; set; }
        public int? AccountingMonthKey { get; set; }
        public int? ActivityMonthKey { get; set; }
        public int GrossNetKey { get; set; }
        public int VendorKey { get; set; }
        public string? ScenarioKey { get; set; }
        public double? Cad { get; set; }
    }
}
