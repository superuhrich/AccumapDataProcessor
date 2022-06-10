using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TBudgetFiscProductListValue
    {
        public string ParentId { get; set; } = null!;
        public string ProductId { get; set; } = null!;
        public int ProductIndex { get; set; }
        public int ProductClass { get; set; }
        public byte IsPrimary { get; set; }
    }
}
