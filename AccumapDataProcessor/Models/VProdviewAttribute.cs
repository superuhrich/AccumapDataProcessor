using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class VProdviewAttribute
    {
        public string? Uwi { get; set; }
        public string? PvunitCostCentre { get; set; }
        public string? PvunitLicenseNum { get; set; }
        public string? PvunitCompletionName { get; set; }
        public string? PvunitName { get; set; }
        public string? PvunitShortName { get; set; }
        public double? GasShrinkageFactor { get; set; }
        public double? NglYieldFactor { get; set; }
        public string Routename { get; set; } = null!;
        public string FlownetName { get; set; } = null!;
        public string? SalesDispositionPoint { get; set; }
        public string? EngineeringOnProdDate { get; set; }
        public string? EngineeringInlineTestDate { get; set; }
        public string? SchematicTypical { get; set; }
    }
}
