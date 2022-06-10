using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TBudgetEntOtherForecast
    {
        public string ParentId { get; set; } = null!;
        public int ForecastType { get; set; }
        public DateTime ForecastDate { get; set; }
        public double ForecastValue { get; set; }
    }
}
