using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TCtrlValnavAccountXref
    {
        public string? CostType { get; set; }
        public string? CostDefinitionId { get; set; }
        public string? CostDefinitionName { get; set; }
        public string? PreviousCostDetailType { get; set; }
        public string? SignFlip { get; set; }
    }
}
