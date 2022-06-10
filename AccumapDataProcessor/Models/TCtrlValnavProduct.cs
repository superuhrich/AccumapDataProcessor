using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TCtrlValnavProduct
    {
        public int ProductId { get; set; }
        public string? Accounts { get; set; }
        public decimal? SiToImpConvFactor { get; set; }
        public decimal? BoeThermal { get; set; }
        public decimal? Mcfe6Thermal { get; set; }
    }
}
