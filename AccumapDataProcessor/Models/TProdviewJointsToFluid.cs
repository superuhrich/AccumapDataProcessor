using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TProdviewJointsToFluid
    {
        public string? Keymigrationsource { get; set; }
        public string? Compida { get; set; }
        public string? CcNum { get; set; }
        public DateTime? Dttm { get; set; }
        public DateTime? CalcDttmStart { get; set; }
        public DateTime? CalcDttmEnd { get; set; }
        public double? JointsToFluid { get; set; }
    }
}
