using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TStgProdviewAllFlownetHierarchy
    {
        public string FlownetId { get; set; } = null!;
        public string? FlownetName { get; set; }
        public string ChildIdrec { get; set; } = null!;
        public string? ChildName { get; set; }
        public string? Typ1 { get; set; }
        public string? Typ2 { get; set; }
        public string ParentIdrec { get; set; } = null!;
        public string? ParentName { get; set; }
        public string? Uwi { get; set; }
        public string? CcNum { get; set; }
        public string? CubeChild { get; set; }
        public string? CubeParent { get; set; }
        public string? Idrecmetereventtk { get; set; }
        public DateTime? Dttmstart { get; set; }
        public DateTime Dttmend { get; set; }
        public DateTime? PvunitDttmend { get; set; }
        public string? MeterType { get; set; }
    }
}
