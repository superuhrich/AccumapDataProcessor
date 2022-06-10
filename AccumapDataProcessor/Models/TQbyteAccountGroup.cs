using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TQbyteAccountGroup
    {
        public DateTime? CreateDate { get; set; }
        public string? CreateUser { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public string? LastUpdateUser { get; set; }
        public string? AcctGroupTypeCode { get; set; }
        public string? AcctGroupCode { get; set; }
        public decimal? DisplaySeqNum { get; set; }
        public string? AcctGroupDesc { get; set; }
        public string? RollupAcctGroupFlag { get; set; }
        public DateTime? AcctGroupDate { get; set; }
    }
}
