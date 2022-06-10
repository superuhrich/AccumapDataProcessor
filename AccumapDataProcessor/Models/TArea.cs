using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TArea
    {
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Province { get; set; } = null!;
        public string? PlatScale { get; set; }
        public string? SurveySystem { get; set; }
        public string? TlCorner { get; set; }
        public string? BrCorner { get; set; }
        public string AiStatus { get; set; } = null!;
        public string? LastUpdateUser { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public decimal? CodeInUse { get; set; }
        public decimal? Reserved { get; set; }
        public string? Division { get; set; }
        public string? CostCenter { get; set; }
        public string? AfeNumber { get; set; }
    }
}
