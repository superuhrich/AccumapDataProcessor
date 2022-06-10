using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class XReference
    {
        public string Subsystem { get; set; } = null!;
        public string FileNumber { get; set; } = null!;
        public string FileSub { get; set; } = null!;
        public string RelSubsystem { get; set; } = null!;
        public string RelFileNumber { get; set; } = null!;
        public string RelFileSub { get; set; } = null!;
        public string? Relationship { get; set; }
        public string? SubType1 { get; set; }
        public decimal? SubAlloc1 { get; set; }
        public string? SubType2 { get; set; }
        public decimal? SubAlloc2 { get; set; }
        public string? Comments { get; set; }
    }
}
