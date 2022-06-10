using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class CSub
    {
        public string FileNumber { get; set; } = null!;
        public string FileSub { get; set; } = null!;
        public string? ReasonForSub { get; set; }
        public string FileStatus { get; set; } = null!;
        public DateTime StatusDate { get; set; }
        public string Division { get; set; } = null!;
        public string Area { get; set; } = null!;
        public string? Operator { get; set; }
        public decimal? TractPartic { get; set; }
        public string? ProjectNumber { get; set; }
        public string? EubFacilityCode { get; set; }
        public string? CapPcntIntYn { get; set; }
    }
}
