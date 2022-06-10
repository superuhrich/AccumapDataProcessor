using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class VQbyteVendor
    {
        public decimal? VendorKey { get; set; }
        public string? VendorName { get; set; }
        public string? VendorAlphaGroup { get; set; }
        public string? BaTypeCode { get; set; }
        public string? PaymentCode { get; set; }
        public string? EncanaBaNumber { get; set; }
        public string? BaCreditStatus { get; set; }
        public string? GovtEntity { get; set; }
        public string? GovtParent { get; set; }
        public string? Aboriginal { get; set; }
        public string? ParentId { get; set; }
        public string? HoldDate { get; set; }
        public string? ApCreditDays { get; set; }
        public string? ArCreditDays { get; set; }
        public DateTime? InactiveDate { get; set; }
    }
}
