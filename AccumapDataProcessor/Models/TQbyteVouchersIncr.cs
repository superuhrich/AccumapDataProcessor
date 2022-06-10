using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TQbyteVouchersIncr
    {
        public decimal? VoucherId { get; set; }
        public decimal? VoucherNum { get; set; }
        public string? VoucherTypeCode { get; set; }
        public decimal? OrgId { get; set; }
        public DateTime? AcctPerDate { get; set; }
        public string? CurrCode { get; set; }
        public string? SrcCode { get; set; }
        public string? VoucherStatCode { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? CreateUser { get; set; }
        public decimal? CtrlAmt { get; set; }
        public decimal? CtrlVol { get; set; }
        public DateTime? GlPostingDate { get; set; }
        public DateTime? CurrConvDate { get; set; }
        public string? SrcModuleId { get; set; }
        public string? VoucherRem { get; set; }
        public string? GlPostUser { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public string? LastUpdateUser { get; set; }
        public decimal? VoucherReversalId { get; set; }
        public decimal? JibRunNum { get; set; }
    }
}
