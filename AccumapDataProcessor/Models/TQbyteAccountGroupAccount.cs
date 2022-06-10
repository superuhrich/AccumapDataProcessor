using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TQbyteAccountGroupAccount
    {
        public DateTime? CreateDate { get; set; }
        public string? CreateUser { get; set; }
        public string? MajorAcct { get; set; }
        public string? MinorAcct { get; set; }
        public string? AcctGroupTypeCode { get; set; }
        public string? AcctGroupCode { get; set; }
        public string? LastUpdateUser { get; set; }
        public DateTime? LastUpdateDate { get; set; }
    }
}
