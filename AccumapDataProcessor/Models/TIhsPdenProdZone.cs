using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TIhsPdenProdZone
    {
        public string PdenId { get; set; } = null!;
        public string PdenType { get; set; } = null!;
        public string Source { get; set; } = null!;
        public string StratUnitId { get; set; } = null!;
        public decimal? TopDepth { get; set; }
        public decimal? BaseDepth { get; set; }
        public decimal? CompletionTop { get; set; }
        public decimal? CompletionBase { get; set; }
        public string ProvinceState { get; set; } = null!;
        public string? RowCreatedBy { get; set; }
        public DateTime? RowCreatedDate { get; set; }
        public string? RowChangedBy { get; set; }
        public DateTime? RowChangedDate { get; set; }
        public string? RowQuality { get; set; }
        public decimal? StratUnitAge { get; set; }
        public decimal? BaseStratAge { get; set; }
        public DateTime? CompletionDate { get; set; }
        public DateTime? PlugbackDate { get; set; }
        public string? StratNameSetId { get; set; }
    }
}
