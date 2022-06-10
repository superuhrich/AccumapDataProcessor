using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TIhsWellNode
    {
        public string NodeId { get; set; } = null!;
        public string? ActiveInd { get; set; }
        public string? CoordinateQuality { get; set; }
        public string? CoordSystemId { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public decimal? Latitude { get; set; }
        public string? LegalSurveyType { get; set; }
        public string? LocationQuality { get; set; }
        public string? LocationType { get; set; }
        public decimal? Longitude { get; set; }
        public decimal? NodeNumericId { get; set; }
        public string? NodePosition { get; set; }
        public decimal? OriginalObsNo { get; set; }
        public string? OriginalXyUom { get; set; }
        public string? PlatformId { get; set; }
        public string? PlatformSfType { get; set; }
        public string? PpdmGuid { get; set; }
        public string? PreferredInd { get; set; }
        public string? Remark { get; set; }
        public decimal? SelectedObsNo { get; set; }
        public string? Source { get; set; }
        public string? Uwi { get; set; }
        public string? RowChangedBy { get; set; }
        public DateTime? RowChangedDate { get; set; }
        public string? RowCreatedBy { get; set; }
        public DateTime? RowCreatedDate { get; set; }
        public string? RowQuality { get; set; }
    }
}
