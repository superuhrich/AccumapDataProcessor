using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class VDimSourceMetrixSalesType
    {
        public string OpNonOp { get; set; } = null!;
        public string SalesTypeCode { get; set; } = null!;
        public string? SalesType { get; set; }
        public decimal? SalesTypeSortKey { get; set; }
        public int IsSales { get; set; }
        public int IsRoyalty { get; set; }
    }
}
