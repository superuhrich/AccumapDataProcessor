using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class VDimOwner
    {
        public string? OwnerId { get; set; }
        public string? OwnerName { get; set; }
        public string? OwnerGovtCode { get; set; }
        public string? OwnerProvince { get; set; }
        public int? SortKey { get; set; }
    }
}
