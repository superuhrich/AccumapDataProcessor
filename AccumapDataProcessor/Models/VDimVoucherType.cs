using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class VDimVoucherType
    {
        public string? VoucherTypeCode { get; set; }
        public string? VoucherTypeDesc { get; set; }
        public string? ParentId { get; set; }
    }
}
