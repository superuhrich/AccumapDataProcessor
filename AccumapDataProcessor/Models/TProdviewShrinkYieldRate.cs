using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TProdviewShrinkYieldRate
    {
        public string? Keymigrationsource { get; set; }
        public string? Compida { get; set; }
        public string? Idflownet { get; set; }
        public DateTime? Dttmstart { get; set; }
        public DateTime? Dttmend { get; set; }
        public double? GasShrinkage { get; set; }
        public double? C2Yield { get; set; }
        public double? C3Yield { get; set; }
        public double? C4Yield { get; set; }
        public double? C5Yield { get; set; }
        public double? CondyYield { get; set; }
        public double? OilYield { get; set; }
        public double? TotalYieldFactor { get; set; }
    }
}
