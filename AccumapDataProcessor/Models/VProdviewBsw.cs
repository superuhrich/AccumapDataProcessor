using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class VProdviewBsw
    {
        public string? Keymigrationsource { get; set; }
        public string? Compida { get; set; }
        public string? CcNum { get; set; }
        public string? Completionname { get; set; }
        public DateTime? Dttmstart { get; set; }
        public DateTime? CalcDttmStart { get; set; }
        public DateTime? CalcDttmEnd { get; set; }
        public double? Bsw { get; set; }
    }
}
