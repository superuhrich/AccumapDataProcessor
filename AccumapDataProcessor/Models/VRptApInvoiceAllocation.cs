using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class VRptApInvoiceAllocation
    {
        public string? ApUser { get; set; }
        public string? InvoiceNumber { get; set; }
        public string? InvoiceKey { get; set; }
        public string? InvoiceDate { get; set; }
        public string? VendorName { get; set; }
        public string OiUrl { get; set; } = null!;
    }
}
