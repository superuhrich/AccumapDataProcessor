using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class VCtrlMarketingSalesPoint
    {
        public string Idflownet { get; set; } = null!;
        public string? FlownetName { get; set; }
        public string? SalesPointIdrec { get; set; }
        public string? SalesPointName { get; set; }
    }
}
