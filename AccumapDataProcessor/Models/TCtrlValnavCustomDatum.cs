using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TCtrlValnavCustomDatum
    {
        public string CustomDataName { get; set; } = null!;
        public string? CalculationName { get; set; }
        public string? DisplayName { get; set; }
        public string CustomDataId { get; set; } = null!;
    }
}
