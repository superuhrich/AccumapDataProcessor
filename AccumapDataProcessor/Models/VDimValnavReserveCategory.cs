using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class VDimValnavReserveCategory
    {
        public string? ReserveCategoryId { get; set; }
        public string? ParentId { get; set; }
        public string? ReserveCategoryAlias { get; set; }
        public string? UnaryOperator { get; set; }
        public string? SortKey { get; set; }
    }
}
