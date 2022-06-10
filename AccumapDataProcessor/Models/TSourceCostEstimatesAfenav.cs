using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TSourceCostEstimatesAfenav
    {
        public string? AfeDocumentId { get; set; }
        public string? Afenumber { get; set; }
        public DateTime? AmountDate { get; set; }
        public string? AmountType { get; set; }
        public string NetGrs { get; set; } = null!;
        public string? AfeType { get; set; }
        public double? Amount { get; set; }
        public decimal? LegacyAfeid { get; set; }
    }
}
