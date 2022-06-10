using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class CheckOnstreamDateBudget
    {
        public string ObjectId { get; set; } = null!;
        public string UniqueId { get; set; } = null!;
        public DateTime StepDate { get; set; }
    }
}
