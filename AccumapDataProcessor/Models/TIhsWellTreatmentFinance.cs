using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TIhsWellTreatmentFinance
    {
        public string Uwi { get; set; } = null!;
        public string Source { get; set; } = null!;
        public decimal TreatmentObsNo { get; set; }
        public string DataSource { get; set; } = null!;
        public string FinanceType { get; set; } = null!;
        public string? ActiveInd { get; set; }
        public decimal? Amount { get; set; }
        public string? AuthorizedBaId { get; set; }
        public string? CurrencyUom { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public DateTime? IssueDate { get; set; }
        public string? PpdmGuid { get; set; }
        public string ProvinceState { get; set; } = null!;
        public string? Remark { get; set; }
        public string? RowChangedBy { get; set; }
        public DateTime? RowChangedDate { get; set; }
        public string? RowCreatedBy { get; set; }
        public DateTime? RowCreatedDate { get; set; }
        public string? RowQuality { get; set; }
    }
}
