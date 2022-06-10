using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TCtrlMetrixProduct
    {
        public string? ProductCode { get; set; }
        public string? ProductName { get; set; }
        public decimal? SiToImpConvFactor { get; set; }
        public decimal? BoeThermal { get; set; }
        public decimal? M3Thermal { get; set; }
        public decimal? Mcfe6Thermal { get; set; }
    }
}
