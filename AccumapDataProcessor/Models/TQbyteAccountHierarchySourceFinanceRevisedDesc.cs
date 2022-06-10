using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TQbyteAccountHierarchySourceFinanceRevisedDesc
    {
        public int? RowId { get; set; }
        public string? ChildId { get; set; }
        public string? ChildAlias { get; set; }
        public string? ParentAlias { get; set; }
        public string? GlAccount { get; set; }
        public string? GlAccountDescription { get; set; }
        public string? MajorAccountDescription { get; set; }
        public string? ClassCodeDescription { get; set; }
        public string? HierarchyPathDesc { get; set; }
        public string? ChildAliasRevised { get; set; }
        public string? ParentAliasRevised { get; set; }
        public string? GlAccountDescriptionRevised { get; set; }
        public string? MajorAccountDescriptionRevised { get; set; }
        public string? ClassCodeDescriptionRevised { get; set; }
        public string? HierarchyPathDescRevised { get; set; }
    }
}
