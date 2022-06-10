using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TIhsWellLicenseStatus
    {
        public string? Uwi { get; set; }
        public string? LicenseId { get; set; }
        public string? LicenseSource { get; set; }
        public string? StatusId { get; set; }
        public string? ActiveInd { get; set; }
        public string? AreaOffice { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public DateTime? FinalDrillDate { get; set; }
        public string? LicenseStatus { get; set; }
        public string? LicenseStatusType { get; set; }
        public string? Licensee { get; set; }
        public string? PpdmGuid { get; set; }
        public string? ProvinceState { get; set; }
        public string? Remark { get; set; }
        public string? Source { get; set; }
        public string? SurfaceLoc { get; set; }
        public string? XComplianceStatus { get; set; }
        public string? XDeemedRiskClass { get; set; }
        public DateTime? XInactiveStatusDate { get; set; }
        public string? XIwcp { get; set; }
        public DateTime? XLastVolActivityDate { get; set; }
        public DateTime? XNextInspectionDate { get; set; }
        public string? XReportedRiskClass { get; set; }
        public DateTime? XReportedSuspDate { get; set; }
        public DateTime? RowChangedDate { get; set; }
        public string? RowChangedBy { get; set; }
        public DateTime? RowCreatedDate { get; set; }
        public string? RowCreatedBy { get; set; }
        public string? RowQuality { get; set; }
    }
}
