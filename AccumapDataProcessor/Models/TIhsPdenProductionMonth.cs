using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TIhsPdenProductionMonth
    {
        public string? PdenId { get; set; }
        public string? PdenType { get; set; }
        public string? Source { get; set; }
        public decimal? Year { get; set; }
        public decimal? Month { get; set; }
        public DateTime? ProdDate { get; set; }
        public decimal? Hours { get; set; }
        public decimal? Gas { get; set; }
        public decimal? Water { get; set; }
        public decimal? OilBt { get; set; }
        public decimal? Cond { get; set; }
        public decimal? CumGas { get; set; }
        public decimal? CumOilBt { get; set; }
        public decimal? CumWater { get; set; }
        public decimal? CumCond { get; set; }
        public decimal? CumHours { get; set; }
        public decimal? TotalFluid { get; set; }
        public decimal? GasCalDay { get; set; }
        public decimal? OilCalDay { get; set; }
        public decimal? WaterCalDay { get; set; }
        public decimal? CondCalDay { get; set; }
        public decimal? TotalFluidCalDay { get; set; }
        public decimal? GasActDay { get; set; }
        public decimal? OilActDay { get; set; }
        public decimal? WaterActDay { get; set; }
        public decimal? CondActDay { get; set; }
        public decimal? TotalFluidActDay { get; set; }
        public decimal? Gor { get; set; }
        public decimal? Wgr { get; set; }
        public decimal? Wor { get; set; }
        public decimal? Wcut { get; set; }
        public decimal? Ocut { get; set; }
        public decimal? Ccut { get; set; }
        public decimal? Cgr { get; set; }
        public decimal? GasFluidRatio { get; set; }
        public decimal? Last3Fluid { get; set; }
        public decimal? Last3Ccut { get; set; }
        public decimal? Last3Ocut { get; set; }
        public decimal? Last3Cgr { get; set; }
        public string ProvinceState { get; set; } = null!;
        public string? RowCreatedBy { get; set; }
        public DateTime? RowCreatedDate { get; set; }
        public string? RowChangedBy { get; set; }
        public DateTime? RowChangedDate { get; set; }
        public string? LastProcess { get; set; }
        public decimal? BrkWater { get; set; }
        public decimal? SrcWater { get; set; }
    }
}
