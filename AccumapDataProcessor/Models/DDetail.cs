using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class DDetail
    {
        public decimal DoiId { get; set; }
        public decimal Occurrence { get; set; }
        public string? Partner { get; set; }
        public decimal? PartnerPercent { get; set; }
        public string? SilentPartner { get; set; }
        public string? PartnerType { get; set; }
        public string? Penalty { get; set; }
        public string? SilentOwner { get; set; }
        public string? Tik { get; set; }
        public string? ExternalUse { get; set; }
        public string? Gst { get; set; }
        public string? Suspended { get; set; }
        public string? SapPartnerType { get; set; }
        public string? NriCalcYn { get; set; }
    }
}
