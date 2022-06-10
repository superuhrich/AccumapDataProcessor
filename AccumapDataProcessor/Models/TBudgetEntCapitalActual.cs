using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TBudgetEntCapitalActual
    {
        public string ParentId { get; set; } = null!;
        public string AfeId { get; set; } = null!;
        public DateTime CostDate { get; set; }
        public double? Value { get; set; }
    }
}
