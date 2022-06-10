using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class VProdviewInjectionVolume
    {
        public string? Keymigrationsource { get; set; }
        public string? Compida { get; set; }
        public string? CcNum { get; set; }
        public string? Completionname { get; set; }
        public string? Typmigrationsource { get; set; }
        public string? Typ1 { get; set; }
        public string? Typ2 { get; set; }
        public DateTime? Dttm { get; set; }
        public double? InjectedProdWater { get; set; }
        public double? InjectedSrcWater { get; set; }
        public double? InjectedPressureKpag { get; set; }
        public double? InjectedGasC02 { get; set; }
    }
}
