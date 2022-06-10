using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TSourceCostEstimatesQbyte
    {
        public string? CcNum { get; set; }
        public string? AfeNum { get; set; }
        public string? MajorAcct { get; set; }
        public string? MinorAcct { get; set; }
        public decimal? SuppGrossEst { get; set; }
        public decimal? SuppNetEst { get; set; }
        public decimal? OrigGrossEst { get; set; }
        public decimal? OrigNetEst { get; set; }
        public decimal? GrossEst { get; set; }
        public decimal? NetEst { get; set; }
    }
}
