using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class VAfenavSourceCostEstimate
    {
        public string? AfeDocumentId { get; set; }
        public string? Afenumber { get; set; }
        public string? AfeType { get; set; }
        public DateTime? AmountDate { get; set; }
        public string AmountType { get; set; } = null!;
        public string NetGrs { get; set; } = null!;
        public decimal? Amount { get; set; }
        public int? LegacyAfeid { get; set; }
    }
}
