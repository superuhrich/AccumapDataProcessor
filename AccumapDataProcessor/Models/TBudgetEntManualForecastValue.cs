using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TBudgetEntManualForecastValue
    {
        public string ParentId { get; set; } = null!;
        public DateTime ManualDate { get; set; }
        public double ManualValue { get; set; }
    }
}
