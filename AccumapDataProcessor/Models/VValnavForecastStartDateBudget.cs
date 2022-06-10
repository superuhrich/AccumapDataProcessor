using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class VValnavForecastStartDateBudget
    {
        public string? FormattedId { get; set; }
        public string ObjectId { get; set; } = null!;
        public string UniqueId { get; set; } = null!;
        public DateTime? ManualDate { get; set; }
        public DateTime? InputForecastDate { get; set; }
        public DateTime? SegmentStartDate { get; set; }
        public DateTime? ForecastStartDate { get; set; }
    }
}
