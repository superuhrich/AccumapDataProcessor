using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class COperCapl90
    {
        public string FileNumber { get; set; } = null!;
        public string? Capl90311Rmks { get; set; }
        public string? Insurance { get; set; }
        public string? Capl90604Rmks { get; set; }
        public string? Marketing { get; set; }
        public string? Capl90604bRmks { get; set; }
        public decimal? MktAPercent { get; set; }
        public decimal? MktADollar { get; set; }
        public decimal? MktBPercent { get; set; }
        public decimal? MktBDollar { get; set; }
        public decimal? MktCPercent { get; set; }
        public decimal? MktCDollar { get; set; }
        public decimal? MktDPercent { get; set; }
        public decimal? MktDDollar { get; set; }
        public string? Capl90903Rmks { get; set; }
        public string? CasingPoint { get; set; }
        public string? Capl901007Rmks { get; set; }
        public decimal? PenaltyDev { get; set; }
        public decimal? PenaltyExp { get; set; }
        public string? Capl901010Rmks { get; set; }
        public decimal? TitleWell { get; set; }
        public string? Capl902401Rmks { get; set; }
        public string? DispOfInterest { get; set; }
        public string? Capl902404Rmks { get; set; }
        public string? Assignment { get; set; }
    }
}
