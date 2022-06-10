using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TDimSalesType
    {
        public string? OpNonOp { get; set; }
        public string? SalesTypeCode { get; set; }
        public string? SalesType { get; set; }
        public int? SalesTypeSortKey { get; set; }
        public int? IsSales { get; set; }
        public int? IsRoyalty { get; set; }
    }
}
