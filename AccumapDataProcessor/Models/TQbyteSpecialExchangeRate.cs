using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TQbyteSpecialExchangeRate
    {
        public decimal? OrgId { get; set; }
        public string? CreateUser { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? LastUpdateUser { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public DateTime? AcctPerDate { get; set; }
        public string? SpecialCurrRateCode { get; set; }
        public string? FromCurrCode { get; set; }
        public string? ToCurrCode { get; set; }
        public decimal? ExchangeRate { get; set; }
    }
}
