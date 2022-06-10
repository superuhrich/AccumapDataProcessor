using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TQbyteCcBnpDivestHierarchy
    {
        public string? HierarchyCode { get; set; }
        public string? DispType { get; set; }
        public string? DispPkg { get; set; }
        public string? DispArea { get; set; }
        public string? DispFacility { get; set; }
        public string? CcNum { get; set; }
        public string Disposed { get; set; } = null!;
    }
}
