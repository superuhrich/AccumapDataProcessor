using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TQbyteCostEstimateItem
    {
        public DateTime? CreateDate { get; set; }
        public string? CreateUser { get; set; }
        public string? LastUpdateUser { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public string? AfeNum { get; set; }
        public decimal? AfeSupplementNum { get; set; }
        public decimal? AfeRevisionNum { get; set; }
        public string? MajorAcct { get; set; }
        public string? MinorAcct { get; set; }
        public decimal? GrossCostEstAmt { get; set; }
        public decimal? NetCostEstAmt { get; set; }
        public string? AfeItemNum { get; set; }
    }
}
