using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TBudgetEntDecline
    {
        public string ObjectId { get; set; } = null!;
        public string ParentId { get; set; } = null!;
        public int SlopeType { get; set; }
        public DateTime? FitStartDate { get; set; }
        public DateTime? FitEndDate { get; set; }
        public double? FitInitialRate { get; set; }
        public double? FitInitialSlope { get; set; }
        public double? FitFinalRate { get; set; }
        public double? FitExponent { get; set; }
        public double? FitError { get; set; }
        public int? FitMethod { get; set; }
        public int? IncInitialRateType { get; set; }
        public double? IncInitialRateValue { get; set; }
        public double? IncInitialRatePercent { get; set; }
        public int? IncFinalRateType { get; set; }
        public double? IncFinalRateValue { get; set; }
        public double? IncFinalRatePercent { get; set; }
        public int? IncEndCumType { get; set; }
        public double? IncEndCumValue { get; set; }
        public double? IncEndCumPercent { get; set; }
    }
}
