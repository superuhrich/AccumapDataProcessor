using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class VProdviewProrationDataIncr
    {
        public string? Uwi { get; set; }
        public string? Costcenter { get; set; }
        public string? Fdc { get; set; }
        public DateTime? Dttm { get; set; }
        public double? ProratedGas { get; set; }
        public double? ProratedOil { get; set; }
        public double? ProratedWater { get; set; }
    }
}
