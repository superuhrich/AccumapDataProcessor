using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class VDimPurchaser
    {
        public string? PurchaserId { get; set; }
        public string? PurchaserName { get; set; }
        public string? PurchaserGrouping { get; set; }
        public int? SortKey { get; set; }
    }
}
