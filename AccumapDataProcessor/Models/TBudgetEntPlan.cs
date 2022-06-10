using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TBudgetEntPlan
    {
        public string ObjectId { get; set; } = null!;
        public string ParentId { get; set; } = null!;
        public string PlanDefinitionId { get; set; } = null!;
        public long ForecastChangeDate { get; set; }
        public long EconChangeDate { get; set; }
        public long LastModifiedDate { get; set; }
        public int ReviewState { get; set; }
    }
}
