using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class VFactSourceAllocatedSalesRawVolume
    {
        public string? FlownetId { get; set; }
        public string? FlownetName { get; set; }
        public string? ChildIdrec { get; set; }
        public string? UwiName { get; set; }
        public string? CcNum { get; set; }
        public string? Typ { get; set; }
        public string? SalesDispositionPoint { get; set; }
        public DateTime? ActivityDate { get; set; }
        public double? AllocatedVolume { get; set; }
        public double? RawVolume { get; set; }
        public double? SalesVolume { get; set; }
    }
}
