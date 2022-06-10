using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TCtrlFixedVarOpex
    {
        public string? QbyteNetMajorMinor { get; set; }
        public string? QbyteMinorDescription { get; set; }
        public decimal? FixedOpexPercent { get; set; }
        public decimal? VariableOpexPercent { get; set; }
        public decimal? TotalOpexPercent { get; set; }
        public decimal? EconFixedPercent { get; set; }
        public decimal? EconVariableGasPercent { get; set; }
        public decimal? EconVariableOilPercent { get; set; }
        public decimal? TotalEconPercent { get; set; }
    }
}
