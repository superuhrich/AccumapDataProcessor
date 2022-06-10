using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TCtrlMarketingEtlVariable
    {
        public string? EtlType { get; set; }
        public string? FlownetId { get; set; }
        public string? FlownetName { get; set; }
        public string? SalesDispositionPoint { get; set; }
        public string? SalesDispositionPointIdrec { get; set; }
        public string? SourceMeter { get; set; }
        public string? SourceMeter2 { get; set; }
        public int? EntryId { get; set; }
    }
}
