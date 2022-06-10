using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TAfenavFieldcostAmount
    {
        public string? DocumentId { get; set; }
        public int? Version { get; set; }
        public decimal? GrossAmount { get; set; }
        public decimal? NetAmount { get; set; }
        public string? ListitemId { get; set; }
        public DateTime? AmountDate { get; set; }
        public string? Account { get; set; }
        public byte? AmountLocked { get; set; }
        public byte? CalcGross { get; set; }
        public byte? CalcNet { get; set; }
        public string? Phase { get; set; }
        public string? CopyOfListitemId { get; set; }
        public string? CopyOfDocumentId { get; set; }
        public string? CopyOfAccount { get; set; }
    }
}
