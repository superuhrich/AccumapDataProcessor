using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TRptRoyaltyControlGroup
    {
        public decimal? WellTractSysId { get; set; }
        public decimal? RoyaltyObligationSysId { get; set; }
        public string? ProductCode { get; set; }
        public decimal? ProductionDate { get; set; }
        public string? ControlGroupId { get; set; }
    }
}
