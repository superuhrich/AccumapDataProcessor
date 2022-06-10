using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TInvoiceAttachment
    {
        public string? InvoiceKey { get; set; }
        public string? AttachmentKey { get; set; }
        public string? LocationPath { get; set; }
        public string? ContentType { get; set; }
        public string? AttachmentType { get; set; }
    }
}
