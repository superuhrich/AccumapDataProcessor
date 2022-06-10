using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TDimProduct
    {
        public string? ProductCode { get; set; }
        public string? ProductDescription { get; set; }
        public int? ProductSortOrder { get; set; }
        public string? ProductGroup { get; set; }
        public int? ProductGroupSort { get; set; }
        public string? ProductGroupTotal { get; set; }
        public int? ProductGroupTotalSort { get; set; }
    }
}
