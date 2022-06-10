using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class VMetrixUnitWell
    {
        public string UnitId { get; set; } = null!;
        public string? UnitName { get; set; }
        public string UnitProvince { get; set; } = null!;
        public string? UnitGovtCode { get; set; }
        public string? UnitCostCentreCode { get; set; }
        public string WellId { get; set; } = null!;
        public string? WellFacilityId { get; set; }
    }
}
