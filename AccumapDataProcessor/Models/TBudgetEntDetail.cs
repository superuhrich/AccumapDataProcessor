using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TBudgetEntDetail
    {
        public string ParentId { get; set; } = null!;
        public string? WellName { get; set; }
        public string? Field { get; set; }
        public string? FieldCode { get; set; }
        public string? Pool { get; set; }
        public string? PoolCode { get; set; }
        public string? Operator { get; set; }
        public string? Licensee { get; set; }
        public string? Unit { get; set; }
        public string? WellStatus { get; set; }
        public string? CountryId { get; set; }
        public string? ProvinceId { get; set; }
        public string? District { get; set; }
        public string? WellType { get; set; }
        public string? Product { get; set; }
        public DateTime? RigReleaseDate { get; set; }
        public DateTime CurrentMonth { get; set; }
        public double? SurfaceLatitude { get; set; }
        public double? SurfaceLongitude { get; set; }
        public double? BottomholeLatitude { get; set; }
        public double? BottomholeLongitude { get; set; }
        public byte IsGrouped { get; set; }
        public string? RootGroupId { get; set; }
        public byte IncludeInReserves { get; set; }
        public long ForecastChangeDate { get; set; }
        public long EconChangeDate { get; set; }
        public DateTime? FirstProdMonth { get; set; }
        public DateTime? LastProdMonth { get; set; }
        public DateTime? FirstInjMonth { get; set; }
        public DateTime? FirstMonthWithDaily { get; set; }
        public DateTime? LastMonthWithDaily { get; set; }
        public DateTime? LastInjMonth { get; set; }
        public string? DataSource { get; set; }
        public int ReviewState { get; set; }
        public int? WellProfileType { get; set; }
        public long LastUpdateDate { get; set; }
        public string? LastUpdateUser { get; set; }
        public string? CrossPlotIpCalc { get; set; }
        public int? CrossPlotDistribution { get; set; }
        public int? CrossPlotNumMonths { get; set; }
        public byte? CrossPlotUseInitRate { get; set; }
        public string? FactorId { get; set; }
        public byte SuppressDefaultCalcSetup { get; set; }
        public string? PrimaryApi { get; set; }
        public string? ProductListId { get; set; }
        public string? ChangeReasonEntityId { get; set; }
        public string? ChangeReasonDetailId { get; set; }
        public string? Zone { get; set; }
        public string? License { get; set; }
        public string? CrossPlotNormlzBase { get; set; }
        public string? CrossPlotNormlzField { get; set; }
        public byte? CrossPlotNormlzEnabled { get; set; }
        public string? CrossPlotProductId { get; set; }
        public int? CrossPlotProductType { get; set; }
        public double? OilDensity { get; set; }
    }
}
