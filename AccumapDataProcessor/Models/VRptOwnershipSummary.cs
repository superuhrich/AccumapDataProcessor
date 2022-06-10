using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class VRptOwnershipSummary
    {
        public string? FileName { get; set; }
        public string? OwnerId { get; set; }
        public string? FilePath { get; set; }
        public string FeesPath { get; set; } = null!;
        public string? AccountingDate { get; set; }
    }
}
