using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TCtrlQbyteConversionFactor
    {
        public decimal? GasSiToImpConvFactor { get; set; }
        public decimal? LiquidSiToImpConvFactor { get; set; }
        public decimal? GasBoeThermal { get; set; }
        public decimal? LiquidBoeThermal { get; set; }
        public decimal? GasMcfe6Thermal { get; set; }
        public decimal? LiquidMcfe6Thermal { get; set; }
    }
}
