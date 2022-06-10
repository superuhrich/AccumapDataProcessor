using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class DXref
    {
        public string AdminCompany { get; set; } = null!;
        public string Subsystem { get; set; } = null!;
        public string FileNumber { get; set; } = null!;
        public string FileSub { get; set; } = null!;
        public DateTime ChangedDate { get; set; }
        public string DoiType { get; set; } = null!;
        public string? DoiStatus { get; set; }
        public string AccountGroup { get; set; } = null!;
        public decimal DoiId { get; set; }
        public DateTime EffectiveDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string Owner { get; set; } = null!;
        public string? Comments { get; set; }
        public decimal? Occurrence { get; set; }
    }
}
