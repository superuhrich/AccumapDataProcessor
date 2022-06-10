using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class OwnerMaster
    {
        public string? CreateUser { get; set; }
        public string? CreateProgram { get; set; }
        public DateTime? CreateDateTime { get; set; }
        public string? LastUpdateUser { get; set; }
        public string? LastUpdateProgram { get; set; }
        public DateTime? LastUpdateDateTime { get; set; }
        public decimal? LastUpdateAuditId { get; set; }
        public decimal? Version { get; set; }
        public decimal? SysId { get; set; }
        public decimal? ProductionDate { get; set; }
        public string? Name { get; set; }
        public string? AddressLine1 { get; set; }
        public string? AddressLine2 { get; set; }
        public string? AddressLine3 { get; set; }
        public string? AddressLine4 { get; set; }
        public string? PostalCode { get; set; }
        public string? PhoneNumber { get; set; }
        public string? FaxNumber { get; set; }
        public string? ContactName { get; set; }
        public string? UserDefined1 { get; set; }
        public string? NrtApplicable { get; set; }
        public decimal? NrtRateOverride { get; set; }
        public string? OwnerId { get; set; }
        public string? JiblinkProvinceCode { get; set; }
        public string? JiblinkCountryCode { get; set; }
        public string? Bc08ReportingOwnerId { get; set; }
        public string? GlobalObligationPayorFlag { get; set; }
    }
}
