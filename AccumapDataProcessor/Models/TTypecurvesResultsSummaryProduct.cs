using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TTypecurvesResultsSummaryProduct
    {
        public string ResultId { get; set; } = null!;
        public string ProductId { get; set; } = null!;
        public double TechCumGrossVolume { get; set; }
        public double TechCumWiVolume { get; set; }
        public double TechCumRiVolume { get; set; }
        public double TechCumNetVolume { get; set; }
        public double TechCumRawGrossVolume { get; set; }
        public double TechCumRawWiVolume { get; set; }
        public double TechCumRawRiVolume { get; set; }
        public double TechCumRawNetVolume { get; set; }
        public double TechRemGrossVolume { get; set; }
        public double TechRemWiVolume { get; set; }
        public double TechRemRiVolume { get; set; }
        public double TechRemNetVolume { get; set; }
        public double TechRemRawGrossVolume { get; set; }
        public double TechRemRawWiVolume { get; set; }
        public double TechRemRawRiVolume { get; set; }
        public double TechRemRawNetVolume { get; set; }
        public double InitialWi { get; set; }
    }
}
