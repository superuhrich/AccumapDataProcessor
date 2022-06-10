using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class GroupDataFromProd
    {
        public string? ObjectId { get; set; }
        public DateTime? ActivityDateKey { get; set; }
        public int? IsZero { get; set; }
        public int? RCount { get; set; }
    }
}
