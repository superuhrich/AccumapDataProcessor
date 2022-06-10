using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class VInvoicesUsed
    {
        public string? InvoiceKey { get; set; }
        public string? InvoiceNumber { get; set; }
        public string? VendorCode { get; set; }
        public string? InvoiceDate { get; set; }
        public string? InvoiceTotal { get; set; }
        public string? InvoiceDescription { get; set; }
        public string? CurrencyCode { get; set; }
        public string? InvoiceType { get; set; }
        public string? Status { get; set; }
        public string? TransportClass { get; set; }
        public string? OverrideInvoiceNumber { get; set; }
        public string VoucherType { get; set; } = null!;
        public int? VendorNumber { get; set; }
        public string? InvoiceNumberInuse { get; set; }
    }
}
