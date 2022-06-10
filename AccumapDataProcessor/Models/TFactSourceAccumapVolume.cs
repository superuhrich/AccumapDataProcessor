using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TFactSourceAccumapVolume
    {
        public string Uwi { get; set; } = null!;
        public decimal? Oil { get; set; }
        public double? Gas { get; set; }
        public double? Water { get; set; }
        public double? Cond { get; set; }
        public double? PHour { get; set; }
        public DateTime? Date { get; set; }
    }
}
