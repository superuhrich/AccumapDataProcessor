using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TOpeninvoiceDetail
    {
        public string? InvoiceKey { get; set; }
        public int? OrgId { get; set; }
        public string? AfeNum { get; set; }
        public string? AfeDesc { get; set; }
        public string? CcNum { get; set; }
        public string? CcDesc { get; set; }
        public string? Account { get; set; }
        public double? Amount { get; set; }
        public string BaInfo { get; set; } = null!;
        public string? InvoiceNumber { get; set; }
        public string? InvoiceStatus { get; set; }
        public string? InvoiceDate { get; set; }
        public DateTime? ActvyPerDate { get; set; }
        public DateTime? InvoiceCreateDate { get; set; }
        public string? DocumentNumber { get; set; }
        public string? AccountDescription { get; set; }
        public string? CreateUser { get; set; }
        public string? LastApprover { get; set; }
        public string? InvcAmount { get; set; }
        public string? MajorAccount { get; set; }
        public string? MinorAccount { get; set; }
        public string VoucherType { get; set; } = null!;
        public int? BaId { get; set; }
        public string? NetAcct { get; set; }
        public string? InvoiceDetailsUrl { get; set; }
    }
}
