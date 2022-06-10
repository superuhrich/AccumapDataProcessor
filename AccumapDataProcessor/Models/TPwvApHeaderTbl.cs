using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TPwvApHeaderTbl
    {
        public string Document { get; set; } = null!;
        public DateTime FolderId { get; set; }
        public int PwrId { get; set; }
        public DateTime? PwrCreateDate { get; set; }
        public int? PwrStatus { get; set; }
        public string? PwrWfPath { get; set; }
        public string? PwrMilestoneId { get; set; }
        public string? PwrBaInfo { get; set; }
        public string? PwrBaComments { get; set; }
        public int? PwrPreApproved { get; set; }
        public int? PwrBypassUpload { get; set; }
        public int? PwrQuickPay { get; set; }
        public int? PwrQpByApprover { get; set; }
        public string? PwrLastApprover { get; set; }
        public DateTime? PwrLastApprovalDate { get; set; }
        public int? ShortPay { get; set; }
        public decimal? ShortPayAmt { get; set; }
        public string? InvcNum { get; set; }
        public DateTime? InvcDate { get; set; }
        public decimal? InvcAmt { get; set; }
        public decimal? GstAmt { get; set; }
        public DateTime? DueDate { get; set; }
        public int? OrgId { get; set; }
        public string? CreateUser { get; set; }
        public string? CurrCode { get; set; }
        public string? InvcRem { get; set; }
        public DateTime? DepositDate { get; set; }
        public int? SeparateChqFlag { get; set; }
        public string? MediumCode { get; set; }
        public string? BankAcctId { get; set; }
        public string? VoucherTypeCode { get; set; }
        public string? VoucherNum { get; set; }
        public string? AcctType { get; set; }
        public DateTime? AcctPerDate { get; set; }
        public string? PurchaseOrderNum { get; set; }
        public string? VoucherRem { get; set; }
        public int? BaId { get; set; }
        public int? AlternateAddressId { get; set; }
        public string? ContractNum { get; set; }
        public DateTime? RcvdDate { get; set; }
        public DateTime? HoldDate { get; set; }
        public string? PaymentCode { get; set; }
        public string? PaymentFormatCode { get; set; }
        public string? PaymentHandlingCode { get; set; }
        public DateTime? DiscountDate { get; set; }
        public decimal? DiscountPct { get; set; }
        public decimal? DiscountAmt { get; set; }
        public decimal? PstAmt { get; set; }
        public string? PaymentReference { get; set; }
        public DateTime? PaymentDate { get; set; }
        public decimal? PaymentAmount { get; set; }
        public string? PaymentMethod { get; set; }
        public string? TaxProvince { get; set; }
        public decimal? ExchangeRate { get; set; }
        public string? FieldTicketNumbers { get; set; }
        public DateTime? PostedDate { get; set; }
    }
}
