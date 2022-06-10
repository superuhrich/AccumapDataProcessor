using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class VDimAfeType
    {
        public string? ParentAfeType { get; set; }
        public string? AfeType { get; set; }
        public string? AfeTypeDesc { get; set; }
        public string? ReportingLevelCode { get; set; }
        public string? AfeTypeGroup { get; set; }
    }
}
