using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TAdmin
    {
        public string Code { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string AiStatus { get; set; } = null!;
        public string? LastUpdateUser { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public decimal? CodeInUse { get; set; }
        public decimal? Reserved { get; set; }
    }
}
