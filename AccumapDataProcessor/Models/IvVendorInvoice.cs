using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class IvVendorInvoice
    {
        public decimal? InvcId { get; set; }
        public decimal? VendorId { get; set; }
        public string? VendorName { get; set; }
    }
}
