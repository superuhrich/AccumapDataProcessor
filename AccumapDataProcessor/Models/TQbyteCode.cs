using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TQbyteCode
    {
        public DateTime? CreateDate { get; set; }
        public string? CreateUser { get; set; }
        public string? LastUpdateUser { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public string? Code { get; set; }
        public string? CodeTypeCode { get; set; }
        public string? CodeDesc { get; set; }
    }
}
