using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TIhsField
    {
        public string? FieldId { get; set; }
        public string? ActiveInd { get; set; }
        public string? Country { get; set; }
        public DateTime? DiscoveryDate { get; set; }
        public string? District { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public string? FieldAbbreviation { get; set; }
        public string? FieldName { get; set; }
        public string? FieldType { get; set; }
        public string? GroupFieldId { get; set; }
        public string? PpdmGuid { get; set; }
        public string? ProvinceState { get; set; }
        public string? Remark { get; set; }
        public string? Source { get; set; }
        public string? RowChangedBy { get; set; }
        public DateTime? RowChangedDate { get; set; }
        public string? RowCreatedBy { get; set; }
        public DateTime? RowCreatedDate { get; set; }
        public string? RowQuality { get; set; }
    }
}
