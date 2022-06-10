using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class Cteak
    {
        public string FlownetId { get; set; } = null!;
        public string? FlownetName { get; set; }
        public int SalesDispositionPoint { get; set; }
        public int SalesDispositionPointIdrec { get; set; }
        public string? CubeChild { get; set; }
        public string? CubeParent { get; set; }
        public string ChildIdrec { get; set; } = null!;
        public string ParentIdrec { get; set; } = null!;
        public string? ChildName { get; set; }
        public string? ParentName { get; set; }
        public string? Uwi { get; set; }
        public string? CcNum { get; set; }
        public int Xlevel { get; set; }
        public string? Idrecmetereventtk { get; set; }
        public string? MeterType { get; set; }
        public DateTime? Dttmstart { get; set; }
        public DateTime Dttmend { get; set; }
    }
}
