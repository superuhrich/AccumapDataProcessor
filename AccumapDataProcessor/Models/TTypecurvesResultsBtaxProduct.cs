using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TTypecurvesResultsBtaxProduct
    {
        public string ResultId { get; set; } = null!;
        public DateTime StepDate { get; set; }
        public string ProductId { get; set; } = null!;
        public double GrossVolume { get; set; }
        public double WiVolume { get; set; }
        public double RiVolume { get; set; }
        public double FiVolume { get; set; }
        public double NetVolume { get; set; }
        public double RawGrossVolume { get; set; }
        public double RawWiVolume { get; set; }
        public double RawRiVolume { get; set; }
        public double RawNetVolume { get; set; }
        public double SuccessWiVolume { get; set; }
        public double FailureWiVolume { get; set; }
        public double SuccessNetVolume { get; set; }
        public double FailureNetVolume { get; set; }
        public double GrossRevenue { get; set; }
        public double WiRevenue { get; set; }
        public double RiRevenue { get; set; }
        public double FiRevenue { get; set; }
        public double NetRevenue { get; set; }
        public double RoyBasisGrossRevenue { get; set; }
        public double RoyBasisWiRevenue { get; set; }
        public double RoyBasisFiRevenue { get; set; }
        public double RoyGrCrown { get; set; }
        public double RoyAdjCrown { get; set; }
        public double RoyGrIndian { get; set; }
        public double RoyAdjIndian { get; set; }
        public double RoyGrFreehold { get; set; }
        public double RoyAdjFreehold { get; set; }
        public double Npv1 { get; set; }
        public double Npv2 { get; set; }
        public double Npv3 { get; set; }
        public double Npv4 { get; set; }
        public double Npv5 { get; set; }
    }
}
