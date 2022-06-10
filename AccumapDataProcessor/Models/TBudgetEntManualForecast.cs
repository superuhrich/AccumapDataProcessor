using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TBudgetEntManualForecast
    {
        public string ObjectId { get; set; } = null!;
        public string ParentId { get; set; } = null!;
        public int? ForecastType { get; set; }
    }
}
