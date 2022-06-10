using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class VDimValnavAccount
    {
        public string? AccountId { get; set; }
        public string? ParentId { get; set; }
        public string? AccountDesc { get; set; }
        public string? AccountFormula { get; set; }
        public string? AccountFormulaProperty { get; set; }
        public string? UnaryOperator { get; set; }
        public string? SortKey { get; set; }
        public string? QbyteMajorMinor { get; set; }
        public string? AfeType { get; set; }
        public int? IsValnav { get; set; }
        public string? Source { get; set; }
    }
}
