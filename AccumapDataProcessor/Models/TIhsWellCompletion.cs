using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TIhsWellCompletion
    {
        public string Uwi { get; set; } = null!;
        public string? Source { get; set; }
        public decimal? CompletionObsNo { get; set; }
        public string? ActiveInd { get; set; }
        public decimal? BaseDepth { get; set; }
        public string? BaseDepthOuom { get; set; }
        public string? BaseStratUnitId { get; set; }
        public DateTime? CompletionDate { get; set; }
        public string? CompletionMethod { get; set; }
        public string? CompletionStratUnitId { get; set; }
        public string? CompletionType { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public string? PpdmGuid { get; set; }
        public string? Remark { get; set; }
        public string? StratNameSetId { get; set; }
        public decimal? TopDepth { get; set; }
        public string? TopDepthOuom { get; set; }
        public string? TopStratUnitId { get; set; }
        public string? RowChangedBy { get; set; }
        public DateTime? RowChangedDate { get; set; }
        public string? RowCreatedBy { get; set; }
        public DateTime? RowCreatedDate { get; set; }
        public string? RowQuality { get; set; }
        public string? XPerfStatus { get; set; }
        public decimal? XPerfShots { get; set; }
        public string? ProvinceState { get; set; }
        public decimal? TopStratAge { get; set; }
        public decimal? BaseStratAge { get; set; }
    }
}
