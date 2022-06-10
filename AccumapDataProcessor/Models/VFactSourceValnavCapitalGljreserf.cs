using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class VFactSourceValnavCapitalGljreserf
    {
        public string? EntityKey { get; set; }
        public DateTime? StepDate { get; set; }
        public int? ActivityDateKey { get; set; }
        public double SuccessGrossValue { get; set; }
        public double SuccessInterestValue { get; set; }
        public double FailureGrossValue { get; set; }
        public double FailureInterestValue { get; set; }
        public int? ReserveCategoryId { get; set; }
        public string? Accounts { get; set; }
        public string? Scenario { get; set; }
        public string? NormalizedTimeKey { get; set; }
        public string ScenarioType { get; set; } = null!;
    }
}
