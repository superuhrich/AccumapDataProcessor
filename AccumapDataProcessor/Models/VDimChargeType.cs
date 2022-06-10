using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class VDimChargeType
    {
        public string ChargeType { get; set; } = null!;
        public string ChargeTypeDescription { get; set; } = null!;
        public string? ChargeTypeName { get; set; }
        public string? ChargeTypeShort { get; set; }
        public string? ChargeTypeSpecificCode { get; set; }
        public string? IsActive { get; set; }
    }
}
