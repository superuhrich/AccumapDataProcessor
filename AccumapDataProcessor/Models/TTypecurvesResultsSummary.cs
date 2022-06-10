using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TTypecurvesResultsSummary
    {
        public string ResultId { get; set; } = null!;
        public string? ExplorerTypeId { get; set; }
        public string? HierarchyId { get; set; }
        public string? RegimeId { get; set; }
        public string EntityName { get; set; } = null!;
        public string UserId { get; set; } = null!;
        public string PriceDeckId { get; set; } = null!;
        public long ResultDelta { get; set; }
        public string? EntityList { get; set; }
        public DateTime? ForecastStart { get; set; }
        public DateTime? ForecastEnd { get; set; }
        public DateTime? ProductionStart { get; set; }
        public DateTime? AbandonDate { get; set; }
        public DateTime? TaxEnd { get; set; }
        public string? CountryId { get; set; }
        public string? ProvinceId { get; set; }
        public string? TaxCalculationId { get; set; }
        public string? EntityCurrencyId { get; set; }
        public byte? CalculationApplyEconLimit { get; set; }
        public double? CalculationCos { get; set; }
        public double? CalculationCoo { get; set; }
        public int? InputPrimaryProduct { get; set; }
        public double? BtaxRor { get; set; }
        public double? AtaxRor { get; set; }
        public double BtaxPayout { get; set; }
        public double BtaxProfitRatio { get; set; }
        public double BtaxProfitRatioNpv1 { get; set; }
        public double BtaxProfitRatioNpv2 { get; set; }
        public double BtaxProfitRatioNpv3 { get; set; }
        public double BtaxProfitRatioNpv4 { get; set; }
        public double BtaxProfitRatioNpv5 { get; set; }
        public double OpCoshareBoe { get; set; }
        public double OpNetBoe { get; set; }
        public double OpWiBoe { get; set; }
        public double CapCoshareBoe { get; set; }
        public double CapNetBoe { get; set; }
        public double CapWiBoe { get; set; }
        public double BtaxNetRevenue { get; set; }
        public double BtaxNpv1 { get; set; }
        public double BtaxNpv2 { get; set; }
        public double BtaxNpv3 { get; set; }
        public double BtaxNpv4 { get; set; }
        public double BtaxNpv5 { get; set; }
        public byte HasReportValue { get; set; }
        public double AtaxPayout { get; set; }
        public double AtaxNetRevenue { get; set; }
        public double AtaxNpv1 { get; set; }
        public double AtaxNpv2 { get; set; }
        public double AtaxNpv3 { get; set; }
        public double AtaxNpv4 { get; set; }
        public double AtaxNpv5 { get; set; }
        public double TaxPaid { get; set; }
        public double AtaxProfitRatio { get; set; }
        public double AtaxProfitRatioNpv1 { get; set; }
        public double AtaxProfitRatioNpv2 { get; set; }
        public double AtaxProfitRatioNpv3 { get; set; }
        public double AtaxProfitRatioNpv4 { get; set; }
        public double AtaxProfitRatioNpv5 { get; set; }
        public DateTime? TerminationDate { get; set; }
        public double InitialGenWi { get; set; }
        public DateTime ReferenceDate { get; set; }
        public DateTime DiscountDate { get; set; }
        public int CalculationType { get; set; }
    }
}
