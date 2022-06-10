using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TTypecurvesFiscPriceDeck
    {
        public string ObjectId { get; set; } = null!;
        public string? Name { get; set; }
        public string? Description { get; set; }
        public long LastChangeDate { get; set; }
    }
}
