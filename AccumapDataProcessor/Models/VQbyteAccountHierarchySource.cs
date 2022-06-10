using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class VQbyteAccountHierarchySource
    {
        public string? ChildId { get; set; }
        public string? ParentId { get; set; }
        public string? ChildAlias { get; set; }
        public string? GlAccount { get; set; }
        public string? GlAccountDescription { get; set; }
        public string? MajorAccount { get; set; }
        public string? MinorAccount { get; set; }
        public string? MajorAccountDescription { get; set; }
        public string? MajorClassCode { get; set; }
        public string? ClassCodeDescription { get; set; }
        public string? ProductCode { get; set; }
        public string? SiToImpConvFactor { get; set; }
        public string? BoeThermal { get; set; }
        public string? Mcfe6Thermal { get; set; }
        public string? ProductDescription { get; set; }
        public string? AccountGroup { get; set; }
        public string? DisplaySequenceNumber { get; set; }
        public string? GrossOrNetCode { get; set; }
        public string? SortKey { get; set; }
        public string IsLeaseops { get; set; } = null!;
        public string IsCapital { get; set; } = null!;
        public string IsValnav { get; set; } = null!;
        public int? ZeroLevel { get; set; }
        public string? HierarchyPath { get; set; }
        public int? Level { get; set; }
    }
}
