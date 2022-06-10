using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class VDimVendor
    {
        public int? VendorKey { get; set; }
        public string? VendorId { get; set; }
        public string? VendorGrouping { get; set; }
        public string? VendorAlias { get; set; }
        public string? VendorSort { get; set; }
        public string? InvoiceId { get; set; }
        public string? BaTypeCode { get; set; }
        public string? PaymentCode { get; set; }
        public string? EncanaBaNumber { get; set; }
        public string? BaCreditStatus { get; set; }
        public string? GovtEntity { get; set; }
        public string? GovtParent { get; set; }
        public string? Aboriginal { get; set; }
        public string? HoldDate { get; set; }
        public string? ApCreditDays { get; set; }
        public string? ArCreditDays { get; set; }
        public string? InactiveDate { get; set; }
    }
}
