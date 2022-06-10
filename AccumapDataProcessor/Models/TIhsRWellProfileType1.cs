using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TIhsRWellProfileType1
    {
        public string WellProfileType { get; set; } = null!;
        public string? Abbreviation { get; set; }
        public string? ActiveInd { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public string? LongName { get; set; }
        public string? PpdmGuid { get; set; }
        public string? Remark { get; set; }
        public string? ShortName { get; set; }
        public string? Source { get; set; }
        public string? RowChangedBy { get; set; }
        public DateTime? RowChangedDate { get; set; }
        public string? RowCreatedBy { get; set; }
        public DateTime? RowCreatedDate { get; set; }
        public string? RowQuality { get; set; }
    }
}
