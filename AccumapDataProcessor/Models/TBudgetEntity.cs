using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TBudgetEntity
    {
        public string ObjectId { get; set; } = null!;
        public string UniqueId { get; set; } = null!;
        public string? FormattedId { get; set; }
        public string? SortingId { get; set; }
        public int EntityType { get; set; }
    }
}
