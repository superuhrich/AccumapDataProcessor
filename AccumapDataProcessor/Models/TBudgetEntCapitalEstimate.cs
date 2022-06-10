using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TBudgetEntCapitalEstimate
    {
        public string ParentId { get; set; } = null!;
        public string AfeId { get; set; } = null!;
        public string? AfeNum { get; set; }
        public string? CostType { get; set; }
        public double? ApprovedEstimate { get; set; }
        public double? RevisedEstimate { get; set; }
        public DateTime? EndDate { get; set; }
        public double? IncurredTotal { get; set; }
    }
}
