using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class VStgIhsVolumesIncr
    {
        public string Uwi { get; set; } = null!;
        public string? CcNum { get; set; }
        public decimal? Oil { get; set; }
        public decimal? Cond { get; set; }
        public decimal? Gas { get; set; }
        public decimal? Water { get; set; }
        public string? Month { get; set; }
        public decimal Year { get; set; }
    }
}
