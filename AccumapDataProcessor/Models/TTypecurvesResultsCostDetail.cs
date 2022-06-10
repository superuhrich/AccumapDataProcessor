using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TTypecurvesResultsCostDetail
    {
        public string ResultId { get; set; } = null!;
        public DateTime StepDate { get; set; }
        public string CostDefinitionId { get; set; } = null!;
        public double SuccessGrossValue { get; set; }
        public double SuccessInterestValue { get; set; }
        public double FailureGrossValue { get; set; }
        public double FailureInterestValue { get; set; }
    }
}
