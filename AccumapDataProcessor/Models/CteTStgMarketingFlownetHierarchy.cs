using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class CteTStgMarketingFlownetHierarchy
    {
        public int? Level { get; set; }
        public string? FlownetId { get; set; }
        public string? FlownetName { get; set; }
        public string? SalesDispositionPoint { get; set; }
        public string? SalesDispositionPointIdrec { get; set; }
        public string? CubeChild { get; set; }
        public string? CubeParent { get; set; }
        public string? ChildIdrec { get; set; }
        public string? ParentIdrec { get; set; }
        public string? ChildName { get; set; }
        public string? ParentName { get; set; }
        public string? Uwi { get; set; }
        public string? CcNum { get; set; }
        public string? Idrecmetereventtk { get; set; }
        public DateTime? Dttmstart { get; set; }
        public DateTime? Dttmend { get; set; }
        public string? MeterType { get; set; }
    }
}
