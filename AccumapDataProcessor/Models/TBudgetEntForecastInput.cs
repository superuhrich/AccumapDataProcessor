using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TBudgetEntForecastInput
    {
        public string ObjectId { get; set; } = null!;
        public string ParentId { get; set; } = null!;
        public string ForecastProductId { get; set; } = null!;
        public double? ConstantValue { get; set; }
        public int? ConstantForecastType { get; set; }
        public byte IsActive { get; set; }
    }
}
