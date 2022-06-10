using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class VDimSourceAccountQbyteHierarchyFinance
    {
        public string? AccountId { get; set; }
        public string? ParentId { get; set; }
        public string? ChildAlias { get; set; }
        public string? GlAccount { get; set; }
        public string? GlAccountDescription { get; set; }
        public string? AccountLevel01Desc { get; set; }
        public string? AccountLevel02Desc { get; set; }
        public string? AccountLevel03Desc { get; set; }
        public string? AccountLevel04Desc { get; set; }
        public string? AccountLevel05Desc { get; set; }
        public string? AccountLevel06Desc { get; set; }
        public string? AccountLevel07Desc { get; set; }
        public string? AccountLevel08Desc { get; set; }
        public string? AccountLevel09Desc { get; set; }
        public string? AccountLevel10Desc { get; set; }
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
        public string SortKey { get; set; } = null!;
        public string? AccountLevel01SortKey { get; set; }
        public string? AccountLevel02SortKey { get; set; }
        public string? AccountLevel03SortKey { get; set; }
        public string? AccountLevel04SortKey { get; set; }
        public string? AccountLevel05SortKey { get; set; }
        public string? AccountLevel06SortKey { get; set; }
        public string? AccountLevel07SortKey { get; set; }
        public string? AccountLevel08SortKey { get; set; }
        public string? AccountLevel09SortKey { get; set; }
        public string? AccountLevel10SortKey { get; set; }
        public int IsLeaseops { get; set; }
        public int IsCapital { get; set; }
        public int IsVolumes { get; set; }
        public int IsValnav { get; set; }
        public int IsFinance { get; set; }
        public int? ZeroLevel { get; set; }
        public string? HierarchyPath { get; set; }
        public int? Level { get; set; }
        public string? DepAccountGroup { get; set; }
        public string? DepAccountId { get; set; }
        public string? DepParentId { get; set; }
        public string? DepChildAlias { get; set; }
        public string? DepGlAccount { get; set; }
        public string? DepGlAccountDescription { get; set; }
        public string? DepLevel01Desc { get; set; }
        public string? DepLevel02Desc { get; set; }
        public string? DepLevel03Desc { get; set; }
        public string? DepLevel04Desc { get; set; }
        public string? DepLevel05Desc { get; set; }
        public string? DepMajorAccount { get; set; }
        public string? DepMinorAccount { get; set; }
        public string? DepMajorAccountDescription { get; set; }
        public string? DepMajorClassCode { get; set; }
        public string? DepClassCodeDescription { get; set; }
        public string DepUnaryOperator { get; set; } = null!;
        public string? DepSortKey { get; set; }
        public string? DepLevel01SortKey { get; set; }
        public string? DepLevel02SortKey { get; set; }
        public string? DepLevel03SortKey { get; set; }
        public string? DepLevel04SortKey { get; set; }
        public string? DepLevel05SortKey { get; set; }
        public string? TaxopAccountGroup { get; set; }
        public string? TaxopAccountId { get; set; }
        public string? TaxopParentId { get; set; }
        public string? TaxopChildAlias { get; set; }
        public string? TaxopGlAccount { get; set; }
        public string? TaxopGlAccountDescription { get; set; }
        public string? TaxopLevel01Desc { get; set; }
        public string? TaxopLevel02Desc { get; set; }
        public string? TaxopLevel03Desc { get; set; }
        public string? TaxopLevel04Desc { get; set; }
        public string? TaxopLevel05Desc { get; set; }
        public string? TaxopMajorAccount { get; set; }
        public string? TaxopMinorAccount { get; set; }
        public string? TaxopMajorAccountDescription { get; set; }
        public string? TaxopMajorClassCode { get; set; }
        public string? TaxopClassCodeDescription { get; set; }
        public string TaxopUnaryOperator { get; set; } = null!;
        public string? TaxopSortKey { get; set; }
        public string? TaxopLevel01SortKey { get; set; }
        public string? TaxopLevel02SortKey { get; set; }
        public string? TaxopLevel03SortKey { get; set; }
        public string? TaxopLevel04SortKey { get; set; }
        public string? TaxopLevel05SortKey { get; set; }
        public string? GcartAccountGroup { get; set; }
        public string? GcartAccountId { get; set; }
        public string? GcartParentId { get; set; }
        public string? GcartChildAlias { get; set; }
        public string? GcartGlAccount { get; set; }
        public string? GcartGlAccountDescription { get; set; }
        public string? GcartLevel01Desc { get; set; }
        public string? GcartLevel02Desc { get; set; }
        public string? GcartLevel03Desc { get; set; }
        public string? GcartLevel04Desc { get; set; }
        public string? GcartLevel05Desc { get; set; }
        public string? GcartMajorAccount { get; set; }
        public string? GcartMinorAccount { get; set; }
        public string? GcartMajorAccountDescription { get; set; }
        public string? GcartMajorClassCode { get; set; }
        public string? GcartClassCodeDescription { get; set; }
        public string GcartUnaryOperator { get; set; } = null!;
        public string? GcartSortKey { get; set; }
        public string? GcartLevel01SortKey { get; set; }
        public string? GcartLevel02SortKey { get; set; }
        public string? GcartLevel03SortKey { get; set; }
        public string? GcartLevel04SortKey { get; set; }
        public string? GcartLevel05SortKey { get; set; }
        public string? EstmaAccountGroup { get; set; }
        public string? EstmaAccountId { get; set; }
        public string? EstmaParentId { get; set; }
        public string? EstmaChildAlias { get; set; }
        public string? EstmaGlAccount { get; set; }
        public string? EstmaGlAccountDescription { get; set; }
        public string? EstmaLevel01Desc { get; set; }
        public string? EstmaLevel02Desc { get; set; }
        public string? EstmaLevel03Desc { get; set; }
        public string? EstmaLevel04Desc { get; set; }
        public string? EstmaLevel05Desc { get; set; }
        public string? EstmaMajorAccount { get; set; }
        public string? EstmaMinorAccount { get; set; }
        public string? EstmaMajorAccountDescription { get; set; }
        public string? EstmaMajorClassCode { get; set; }
        public string? EstmaClassCodeDescription { get; set; }
        public string EstmaUnaryOperator { get; set; } = null!;
        public string? EstmaSortKey { get; set; }
        public string? EstmaLevel01SortKey { get; set; }
        public string? EstmaLevel02SortKey { get; set; }
        public string? EstmaLevel03SortKey { get; set; }
        public string? EstmaLevel04SortKey { get; set; }
        public string? EstmaLevel05SortKey { get; set; }
        public string Source { get; set; } = null!;
    }
}
