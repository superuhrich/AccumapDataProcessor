using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class PaSplitsHistory
    {
        public DateTime? ArchiveDate { get; set; }
        public string? Arcontract { get; set; }
        public string? ProdMonth { get; set; }
        public string? AcctMonth { get; set; }
        public string? ControlGroup { get; set; }
        public string? Pa { get; set; }
        public double? Volume { get; set; }
        public double? Energy { get; set; }
        public double? Revenue { get; set; }
        public string? Owner { get; set; }
        public DateTime? LastUpdateDate { get; set; }
    }
}
