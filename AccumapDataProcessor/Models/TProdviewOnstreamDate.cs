using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TProdviewOnstreamDate
    {
        public string? SiteId { get; set; }
        public string? Uwi { get; set; }
        public string? CcNum { get; set; }
        public DateTime? OnstreamDate { get; set; }
        public string? OnstreamYear { get; set; }
    }
}
