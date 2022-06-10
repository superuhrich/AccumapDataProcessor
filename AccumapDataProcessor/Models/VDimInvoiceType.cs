using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class VDimInvoiceType
    {
        public string? InvoiceTypeCode { get; set; }
        public string? InvoiceTypeDescription { get; set; }
        public string? InvoiceTypeLongDesc { get; set; }
        public string? ParentId { get; set; }
        public string? CtrlMajorAcct { get; set; }
        public string? CtrlMinorAcct { get; set; }
        public string? GlAccount { get; set; }
        public int? SortKey { get; set; }
    }
}
