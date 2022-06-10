using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TQbyteFaBaProperty
    {
        public DateTime? CreateDate { get; set; }
        public string? CreateUser { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public string? LastUpdateUser { get; set; }
        public decimal? BaId { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public string? AlternateBaIdReqdFlag { get; set; }
        public string? UseJibeDoiEditsFlag { get; set; }
        public string? WitholdingTaxFlag { get; set; }
        public string? WorkersCompFlag { get; set; }
        public string? PaymentCode { get; set; }
        public string? BillingCode { get; set; }
        public DateTime? HoldDate { get; set; }
        public decimal? SubsystemComponentId { get; set; }
        public decimal? TransactingBaId { get; set; }
        public decimal? PaidToBaId { get; set; }
        public decimal? ApCreditDays { get; set; }
        public decimal? ArCreditDays { get; set; }
        public decimal? ArCreditLimitAmt { get; set; }
        public DateTime? CreditRevisedDate { get; set; }
        public decimal? DiscountCreditDays { get; set; }
        public decimal? DiscountPct { get; set; }
        public string? RecFormatCode { get; set; }
        public string? SendFormatCode { get; set; }
        public string? SendMethodCode { get; set; }
        public string? AdxNum { get; set; }
        public DateTime? InactiveDate { get; set; }
        public string? InactivatedUser { get; set; }
        public decimal? DefaultBaAddressId { get; set; }
        public string? InvcDateInUniqueCheckFlag { get; set; }
        public string? ExcludeFromDupPaymentFlag { get; set; }
        public string? PrintJibStatementFlag { get; set; }
    }
}
