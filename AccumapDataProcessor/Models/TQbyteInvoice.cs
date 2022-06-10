using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TQbyteInvoice
    {
        public DateTime? CreateDate { get; set; }
        public string? CreateUser { get; set; }
        public string? InvcTypeCode { get; set; }
        public string? PayableOrReceivableCode { get; set; }
        public decimal? CreditDays { get; set; }
        public decimal? InvcId { get; set; }
        public string? InvcNum { get; set; }
        public DateTime? InvcDate { get; set; }
        public decimal? ClientId { get; set; }
        public decimal? InvcAmt { get; set; }
        public string? InvcOriginCode { get; set; }
        public string? PayStatCode { get; set; }
        public string? PriorityCode { get; set; }
        public DateTime? RcvdDate { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime? HoldDate { get; set; }
        public DateTime? SentForApprovalDate { get; set; }
        public DateTime? ApprovalDate { get; set; }
        public string? ApprovalRem { get; set; }
        public string? SentTo { get; set; }
        public decimal? GstAmt { get; set; }
        public decimal? GstFactor { get; set; }
        public decimal? ReleaseForPaymentAmt { get; set; }
        public string? SeparateChqFlag { get; set; }
        public string? AfeNum { get; set; }
        public string? CcNum { get; set; }
        public string? InvcRem { get; set; }
        public decimal? VoucherId { get; set; }
        public decimal? NrwtAmt { get; set; }
        public decimal? AlternateAddressId { get; set; }
        public string? PurchaseOrderNum { get; set; }
        public string? AttachmentReqdFlag { get; set; }
        public string? ContractNum { get; set; }
        public decimal? PstAmt { get; set; }
        public decimal? GstDistributionAmt { get; set; }
        public string? PaymentCode { get; set; }
        public DateTime? DiscountDueDate { get; set; }
        public decimal? DiscountAmt { get; set; }
        public string? DiscountAchieved { get; set; }
        public decimal? MiscellaneousIncomeAmt { get; set; }
        public decimal? WithholdingTaxAmt { get; set; }
        public decimal? InvoiceApprovalIndividualId { get; set; }
        public decimal? AlternateClientId { get; set; }
        public string? PaymentFormatCode { get; set; }
        public string? PaymentHandlingCode { get; set; }
        public string? ChqMailTypeCode { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public string? LastUpdateUser { get; set; }
        public decimal? OrgId { get; set; }
    }
}
