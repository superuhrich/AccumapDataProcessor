using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class VRptCsxWellInsuranceElection
    {
        public string FileNumber { get; set; } = null!;
        public string FileStatus { get; set; } = null!;
        public string WellUwi { get; set; } = null!;
        public string WellStatus { get; set; } = null!;
        public string SortedUwi { get; set; } = null!;
        public string? LicenceNumber { get; set; }
        public string ContractFileNumber { get; set; } = null!;
        public string? InsuranceElection { get; set; }
    }
}
