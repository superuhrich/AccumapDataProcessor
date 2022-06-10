using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class VDimSourceAccountQbyteHierarchy
    {
        public string? AccountId { get; set; }
        public string? ParentId { get; set; }
        public string? ChildAlias { get; set; }
        public string? GlAccount { get; set; }
        public string? GlAccountDescription { get; set; }
        public string? AccountLevel01 { get; set; }
        public string? AccountLevel02 { get; set; }
        public string? AccountLevel03 { get; set; }
        public string? AccountLevel04 { get; set; }
        public string? AccountLevel05 { get; set; }
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
        public string UnaryOperator { get; set; } = null!;
        public string? SortKey { get; set; }
        public string? AccountLevel01SortKey { get; set; }
        public string? AccountLevel02SortKey { get; set; }
        public string? AccountLevel03SortKey { get; set; }
        public string? AccountLevel04SortKey { get; set; }
        public string? AccountLevel05SortKey { get; set; }
        public int IsLeaseops { get; set; }
        public int IsCapital { get; set; }
        public int IsVolumes { get; set; }
        public int IsValnav { get; set; }
        public int? ZeroLevel { get; set; }
        public string? HierarchyPath { get; set; }
        public int? Level { get; set; }
        public string Source { get; set; } = null!;
    }
}
