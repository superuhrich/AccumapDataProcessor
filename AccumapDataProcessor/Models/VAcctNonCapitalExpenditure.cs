using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class VAcctNonCapitalExpenditure
    {
        public string? MajorAcct { get; set; }
        public string? MinorAcct { get; set; }
        public string? GlNetAccount { get; set; }
        public string? AccountDescription { get; set; }
        public string? MajorAccountDescription { get; set; }
        public string? MajorClassCode { get; set; }
        public string? ClassCodeDescription { get; set; }
        public string? ProductCode { get; set; }
    }
}
