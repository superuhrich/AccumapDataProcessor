using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TQbyteUdfCode
    {
        public string? Code { get; set; }
        public string? UdfTypeCode { get; set; }
        public string? Description { get; set; }
        public string? CreateUser { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? LastUpdateUser { get; set; }
    }
}
