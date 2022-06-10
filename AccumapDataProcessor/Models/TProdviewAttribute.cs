using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TProdviewAttribute
    {
        public string? Uwi { get; set; }
        public string? PvunitCompletionName { get; set; }
        public string? PvunitName { get; set; }
        public string? PvunitShortName { get; set; }
        public decimal? GasShrinkageFactor { get; set; }
        public decimal? NglYieldFactor { get; set; }
        public string? Routename { get; set; }
        public string? FlownetName { get; set; }
        public string? SalesDispositionPoint { get; set; }
        public string? EngineeringOnProdDate { get; set; }
        public string? EngineeringInlineTestDate { get; set; }
        public string? SchematicTypical { get; set; }
    }
}
