using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class VFactSourcePowervision
    {
        public int? OrgId { get; set; }
        public string? AfeNum { get; set; }
        public string? AfeDesc { get; set; }
        public string? CcNum { get; set; }
        public string? CcDesc { get; set; }
        public string? Account { get; set; }
        public decimal? ReportingCurrAmt { get; set; }
        public string? PwrBaInfo { get; set; }
        public string? InvcNum { get; set; }
        public DateTime? InvcDate { get; set; }
        public DateTime? ActvyPerDate { get; set; }
        public DateTime? PwrCreateDate { get; set; }
        public string Document { get; set; } = null!;
        public string? AccountDesc { get; set; }
        public string? PwrWfPath { get; set; }
        public string? CreateUser { get; set; }
        public string? PwrLastApprover { get; set; }
        public decimal? InvcAmt { get; set; }
        public string? MajorAcct { get; set; }
        public string? MinorAcct { get; set; }
        public string? VoucherTypeCode { get; set; }
        public int? BaId { get; set; }
        public string? NetAcct { get; set; }
    }
}
