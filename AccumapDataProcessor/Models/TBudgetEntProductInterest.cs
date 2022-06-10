using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TBudgetEntProductInterest
    {
        public string ObjectId { get; set; } = null!;
        public string ParentId { get; set; } = null!;
        public string Product { get; set; } = null!;
        public DateTime? StartDate { get; set; }
        public string? CustomData { get; set; }
        public byte? UseManualRoyalty { get; set; }
        public byte? AffectedByCalcDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
