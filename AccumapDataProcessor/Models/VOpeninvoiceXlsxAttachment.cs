using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class VOpeninvoiceXlsxAttachment
    {
        public string? InvoiceKey { get; set; }
        public string? AttachmentKey { get; set; }
        public string? LocationPath { get; set; }
        public string? Filename { get; set; }
    }
}
