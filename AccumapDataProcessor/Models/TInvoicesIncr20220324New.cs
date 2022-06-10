using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TInvoicesIncr20220324New
    {
        public string? InvoiceKey { get; set; }
        public string? InvoiceNumber { get; set; }
        public string? VendorCode { get; set; }
        public string? InvoiceDate { get; set; }
        public double? InvoiceTotal { get; set; }
        public string? InvoiceDescription { get; set; }
        public string? CurrencyCode { get; set; }
        public string? InvoiceType { get; set; }
        public string? Status { get; set; }
        public string? TransportClass { get; set; }
        public string? OverrideInvoiceNumber { get; set; }
        public string? SiteName { get; set; }
        public string? DepartmentName { get; set; }
        public string? CurrentOwnerFirstName { get; set; }
        public string? CurrentOwnerLastName { get; set; }
    }
}
