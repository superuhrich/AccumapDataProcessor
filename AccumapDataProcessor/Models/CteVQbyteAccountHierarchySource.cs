using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class CteVQbyteAccountHierarchySource
    {
        public string? ChildId { get; set; }
        public string? ParentId { get; set; }
        public string? ChildAlias { get; set; }
        public string? GlAccountDescription { get; set; }
        public string? AccountUda { get; set; }
        public string? ClassCodeDescription { get; set; }
        public string? ProductUda { get; set; }
        public string? SiToImpConvFactor { get; set; }
        public string? BoeThermal { get; set; }
        public string? Mcfe6Thermal { get; set; }
        public string? ProductDescription { get; set; }
        public string? GrossOrNetCode { get; set; }
        public string? AccountGroup { get; set; }
        public string? DisplaySeqNum { get; set; }
        public string? MajorMinor { get; set; }
        public string? MajorAccount { get; set; }
        public string? MajorAccountDescription { get; set; }
        public string? MinorAccount { get; set; }
        public string? SortKey { get; set; }
        public int? ZeroLevel { get; set; }
        public string? HierarchyPath { get; set; }
        public int? Level { get; set; }
    }
}
