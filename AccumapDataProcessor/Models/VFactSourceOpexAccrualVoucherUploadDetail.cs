using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class VFactSourceOpexAccrualVoucherUploadDetail
    {
        public decimal? Voucher { get; set; }
        public decimal? OrgId { get; set; }
        public string? MajorAcct { get; set; }
        public string? MinorAcct { get; set; }
        public string? AfeNumber { get; set; }
        public string? AfeItemNumber { get; set; }
        public string? CcNum { get; set; }
        public string? GlSubCode { get; set; }
        public string? VoucherAmount { get; set; }
        public string? ActvyPerDate { get; set; }
        public decimal? Volume { get; set; }
        public string? NonStandardVolume { get; set; }
        public string? EnterYToCreateNewInvoice { get; set; }
        public string? SourceInvoiceId { get; set; }
        public string? BussinessAssociate { get; set; }
        public string? AlternateAddress { get; set; }
        public string? InvoiceNumber { get; set; }
        public string? InvoiceDate { get; set; }
        public string? GoverningAgreementTypeCode { get; set; }
        public string? GorverningAgreementId { get; set; }
        public string? LineItemRemark { get; set; }
        public string? ContinuityCode { get; set; }
        public string? LineItemEneryAmount { get; set; }
        public string? VoucherGstAmount { get; set; }
        public string? OperatingTranslationRate { get; set; }
        public string? OperatingAmount { get; set; }
        public string? OperatingGstAmount { get; set; }
        public string? MainReportTranslationRate { get; set; }
        public string? MainReportingAmount { get; set; }
        public string? VoucherGrossUpAmount { get; set; }
        public string? OperatingGrossUpAmount { get; set; }
        public string? MainReportingGrossUpAmt { get; set; }
        public string? OperatingGrossUpVolume { get; set; }
        public string? OperatingGrosUpEnergyValue { get; set; }
        public string? DueDate { get; set; }
        public string? HoldDate { get; set; }
        public string? InvoiceRemark { get; set; }
        public string? InvoiceAlternateClientId { get; set; }
        public string? PurchaseOrderNumber { get; set; }
        public string? ContractNumber { get; set; }
        public string? QuickPay { get; set; }
        public string? PaymentCode { get; set; }
        public string? PaymentFormatCode { get; set; }
        public string? PaymentHandlingCode { get; set; }
        public string? SeparateChequeFlag { get; set; }
        public string? ChequeMailTypeCode { get; set; }
        public string? AttachmentRequiredFlag { get; set; }
        public string? InvoiceApprovalShortName { get; set; }
        public string? MiscellaneousCode { get; set; }
        public string? UserDefinedFlag { get; set; }
        public string? AlternateGlCode { get; set; }
        public string? LineItemsAlternateClientId { get; set; }
        public string? Footnote { get; set; }
        public string? BilledDate { get; set; }
    }
}
