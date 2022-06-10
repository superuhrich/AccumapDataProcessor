using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class VMetrixUnitTract
    {
        public string UnitId { get; set; } = null!;
        public string UnitProvince { get; set; } = null!;
        public string? UnitName { get; set; }
        public string? UnitGovtCode { get; set; }
        public string? UnitCostCentreCode { get; set; }
        public string TractId { get; set; } = null!;
        public decimal? ProductionPercent { get; set; }
        public decimal? CrownPercent { get; set; }
        public decimal? FederalPercent { get; set; }
    }
}
