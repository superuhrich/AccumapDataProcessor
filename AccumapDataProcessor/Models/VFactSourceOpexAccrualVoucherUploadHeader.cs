using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class VFactSourceOpexAccrualVoucherUploadHeader
    {
        public string? AcctPeriod { get; set; }
        public string? OrgId { get; set; }
        public string? SourceCode { get; set; }
        public string? VoucherType { get; set; }
        public string? CurrencyCode { get; set; }
        public string? Remarks { get; set; }
    }
}
