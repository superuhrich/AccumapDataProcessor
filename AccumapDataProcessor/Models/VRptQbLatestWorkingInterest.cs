using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class VRptQbLatestWorkingInterest
    {
        public string? CcNum { get; set; }
        public string? Uwi { get; set; }
        public decimal? OwnershipLinkId { get; set; }
        public decimal? AgreementId { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public DateTime? NextEffectiveDate { get; set; }
        public decimal? OrgId { get; set; }
        public string? MajorAcct { get; set; }
        public string? MinorAcct { get; set; }
        public DateTime? LastUpdtDate { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? AcctGroupCode { get; set; }
        public long? Rank { get; set; }
        public decimal? PartnerBaId { get; set; }
        public decimal? LaPartnerPct { get; set; }
        public decimal? QbDoi { get; set; }
        public decimal? TotalWi { get; set; }
        public string? CcTypeCode { get; set; }
        public string? CodeDesc { get; set; }
        public DateTime? TermDate { get; set; }
        public decimal? BaId { get; set; }
        public string? BaName { get; set; }
        public long? PctRnk { get; set; }
    }
}
