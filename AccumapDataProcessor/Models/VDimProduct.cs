using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class VDimProduct
    {
        public string? ProductCode { get; set; }
        public string? ProductDescription { get; set; }
        public string? ProductGroup { get; set; }
        public int? SortKey { get; set; }
        public int? GroupSortKey { get; set; }
        public string? ProductGroupTotal { get; set; }
        public int? ProductGroupTotalSort { get; set; }
    }
}
