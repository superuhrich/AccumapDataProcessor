using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TDimAccountCapitalClean
    {
        public string? AccountId { get; set; }
        public string? ParentId { get; set; }
        public string? AccountDesc { get; set; }
        public string? AccountLevel01 { get; set; }
        public string? AccountLevel02 { get; set; }
        public string? AccountLevel03 { get; set; }
        public string? AccountLevel04 { get; set; }
        public string? AccountLevel05 { get; set; }
        public string? AccountFormula { get; set; }
        public string? AccountFormulaProperty { get; set; }
        public string? UnaryOperator { get; set; }
        public string? MajorAccount { get; set; }
        public string? MinorAccount { get; set; }
        public string? GlAccount { get; set; }
        public string? MajorAccountDescription { get; set; }
        public string? MajorClassCode { get; set; }
        public string? ClassCodeDescription { get; set; }
        public string? ProductCode { get; set; }
        public string? Source { get; set; }
        public string? SortKey { get; set; }
        public long? Id { get; set; }
        public DateTime? LastUpdatedDtm { get; set; }
    }
}
