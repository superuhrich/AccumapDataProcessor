using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class VDimAccumapLicense
    {
        public string? CurrentLicensee { get; set; }
        public string? LicenseNumber { get; set; }
        public DateTime? LicenseDate { get; set; }
    }
}
