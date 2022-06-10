using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TQbyteVoucherType
    {
        public string VoucherTypeCode { get; set; } = null!;
        public string VoucherTypeDesc { get; set; } = null!;
        public string GlReportingLevelCode { get; set; } = null!;
        public string? OnLinePostFlag { get; set; }
        public string? AccrualFlag { get; set; }
        public string? StandardEntryTypeFlag { get; set; }
        public string? VoucherTypeUseCode { get; set; }
        public string? AutoGenInBatchEditFlag { get; set; }
        public string? PopulateCompanyCodeFlag { get; set; }
        public string? TranslationMode { get; set; }
        public string? CurrencyAdjustmentFlag { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? CreateUser { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public string? LastUpdateUser { get; set; }
    }
}
