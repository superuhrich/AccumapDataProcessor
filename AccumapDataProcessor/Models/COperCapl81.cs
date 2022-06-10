using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class COperCapl81
    {
        public string FileNumber { get; set; } = null!;
        public string? Capl81311Rmks { get; set; }
        public string? Insurance { get; set; }
        public string? Capl81903Rmks { get; set; }
        public string? CasingPoint { get; set; }
        public string? Capl812401Rmks { get; set; }
        public string? DispOfInterest { get; set; }
        public string? Capl811007Rmks { get; set; }
        public decimal? PenaltyDev { get; set; }
        public decimal? PenaltyExp { get; set; }
    }
}
