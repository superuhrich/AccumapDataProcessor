using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class VEwfEventSequenceInfo
    {
        public string? Wellbore { get; set; }
        public string? Uwi { get; set; }
        public string? Modes { get; set; }
        public DateTime? CurrentStatusDate { get; set; }
        public string? Pool { get; set; }
        public string? ProductionZone { get; set; }
        public DateTime? OnProductionDate { get; set; }
        public string? CostCenter { get; set; }
        public double? WorkingInterest { get; set; }
        public string? Unit { get; set; }
        public string? FormattedUwi { get; set; }
        public string? SortedUwi { get; set; }
        public string? WellType { get; set; }
        public string? WellEventType { get; set; }
        public long? RowId { get; set; }
    }
}
