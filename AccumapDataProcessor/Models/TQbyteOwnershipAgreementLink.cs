using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TQbyteOwnershipAgreementLink
    {
        public DateTime? CreateDate { get; set; }
        public string? CreateUser { get; set; }
        public decimal? OrgId { get; set; }
        public DateTime? LastUpdtDate { get; set; }
        public string? LastUpdtUser { get; set; }
        public DateTime? TermDate { get; set; }
        public string? TermUser { get; set; }
        public decimal? OwnershipLinkId { get; set; }
        public decimal? AgreementId { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public string? AfeNum { get; set; }
        public string? CcNum { get; set; }
        public string? MajorAcct { get; set; }
        public string? MinorAcct { get; set; }
        public string? BurdenId { get; set; }
        public string? RoyaltyAgreementRef { get; set; }
        public string? ProductionRevenueCode { get; set; }
        public string? BillCode { get; set; }
        public string? ExternalReferenceId { get; set; }
        public string? AcctGroupCode { get; set; }
        public string? TerminateFlag { get; set; }
        public decimal? MassUpdateId { get; set; }
    }
}
