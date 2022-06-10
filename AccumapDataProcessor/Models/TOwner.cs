using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TOwner
    {
        public string Owner { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string CalculateNets { get; set; } = null!;
        public string? ChequeRun { get; set; }
        public string? ChequeOwner { get; set; }
        public string? RuainvRun { get; set; }
        public string? RuainvOwner { get; set; }
        public string AiStatus { get; set; } = null!;
        public string? LastUpdateUser { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public decimal? CodeInUse { get; set; }
        public decimal? Reserved { get; set; }
    }
}
