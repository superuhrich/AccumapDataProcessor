using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class VDimValnavGrossNet
    {
        public string? GrossNetId { get; set; }
        public string? ParentId { get; set; }
        public string? GrossNetAlias { get; set; }
        public string? UnaryOperator { get; set; }
        public string? SortKey { get; set; }
    }
}
