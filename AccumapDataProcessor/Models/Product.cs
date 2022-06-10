using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class Product
    {
        public string? CreateUser { get; set; }
        public string? CreateProgram { get; set; }
        public DateTime? CreateDateTime { get; set; }
        public string? LastUpdateUser { get; set; }
        public string? LastUpdateProgram { get; set; }
        public DateTime? LastUpdateDateTime { get; set; }
        public decimal? LastUpdateAuditId { get; set; }
        public decimal? Version { get; set; }
        public string? Description { get; set; }
        public string? ShortDescription { get; set; }
        public decimal? SortOrder { get; set; }
        public string? ActiveValue { get; set; }
        public string? Code { get; set; }
        public string? GeneralUsage { get; set; }
        public string? OilGasUsage { get; set; }
        public string? GasDispositionUsage { get; set; }
        public string? NonGasDispositionUsage { get; set; }
        public string? BatteryDispositionUsage { get; set; }
        public string? CombineNglUsage { get; set; }
        public string? FinancialInterfaceUsage { get; set; }
        public string? PartnerOperatedUsage { get; set; }
        public string? FacilityChargeUsage { get; set; }
        public string? InjectionSummaryUsage { get; set; }
        public string? InjectionReceiptUsage { get; set; }
        public string? InjectionDeliveryUsage { get; set; }
        public string? InjectionDisposalUsage { get; set; }
        public string? FdcInjectionUsage { get; set; }
        public string? FdcAdjustmentUsage { get; set; }
        public string? InjectionSummaryCode { get; set; }
        public string? InjectionSummaryReportCode { get; set; }
        public string? InjectionReceiptReportCode { get; set; }
        public string? InjectionDeliveryReportCode { get; set; }
        public string? InjectionDisposalReportCode { get; set; }
        public string? BaseProductUsage { get; set; }
        public string? CtpOilUsage { get; set; }
        public string? ReportAsUsage { get; set; }
        public string? InjectionConsumptionUsage { get; set; }
        public string? GeqAllowedFlag { get; set; }
        public string? CompositionAllowedFlag { get; set; }
        public string? GigajoulesAllowedFlag { get; set; }
        public string? GasByproductUsage { get; set; }
        public decimal? GasEquivalentFactor { get; set; }
        public string? ReportOilAsUsage { get; set; }
        public string? ReportWaterAsUsage { get; set; }
        public string? ParentProductCode { get; set; }
        public string? RoyaltyBypUsage { get; set; }
        public string? ObligUsage { get; set; }
        public string? MixFlag { get; set; }
        public string? SpecFlag { get; set; }
        public string? SpecProductCode { get; set; }
        public string? ParentSpecProductCode { get; set; }
        public string? NglValReportingProdCode { get; set; }
    }
}
