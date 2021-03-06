using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class VFactSourceApAr
    {
        public string? InvcTypeCode { get; set; }
        public int? BaId { get; set; }
        public string? InvcId { get; set; }
        public string? InvcNum { get; set; }
        public int? InvoiceDate { get; set; }
        public int? OrgId { get; set; }
        public int? AccountingMonth { get; set; }
        public int? DueDate { get; set; }
        public string? VoucherId { get; set; }
        public string? VoucherTypeCode { get; set; }
        public string? VoucherNum { get; set; }
        public string? LiTypeCode { get; set; }
        public decimal? Cad { get; set; }
        public decimal? InvoiceAmount { get; set; }
    }
}
