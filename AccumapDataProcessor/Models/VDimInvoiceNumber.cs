using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class VDimInvoiceNumber
    {
        public string? InvoiceNumber { get; set; }
        public string? InvoiceDescription { get; set; }
        public string? PaymentStatusCode { get; set; }
        public string? PaymentStatusDesc { get; set; }
        public DateTime? HoldDate { get; set; }
        public string? InvoiceId { get; set; }
    }
}
