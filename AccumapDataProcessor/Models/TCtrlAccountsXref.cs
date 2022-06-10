using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TCtrlAccountsXref
    {
        public string SourceApp { get; set; } = null!;
        public string SourceTable { get; set; } = null!;
        public string SourceColumn { get; set; } = null!;
        public string? SourceMajorAcct { get; set; }
        public string? SourceMinorAcct { get; set; }
        public string? Account { get; set; }
        public string? SourceDesc { get; set; }
        public string? TargetMajorAcct { get; set; }
        public string? TargetMinorAcct { get; set; }
        public string TargetAccount { get; set; } = null!;
        public string? TargetParent { get; set; }
        public string TargetApp { get; set; } = null!;
        public string? IsActive { get; set; }
        public string? SortKey { get; set; }
    }
}
