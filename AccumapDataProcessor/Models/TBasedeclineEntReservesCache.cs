using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TBasedeclineEntReservesCache
    {
        public string ParentId { get; set; } = null!;
        public string EntityId { get; set; } = null!;
        public string PlanDefinitionId { get; set; } = null!;
        public string ReserveCategoryId { get; set; } = null!;
        public DateTime? ForecastStartDate { get; set; }
        public double SurfaceLoss { get; set; }
        public double FuelLoss { get; set; }
        public double ProcessLoss { get; set; }
        public double TotalGasLoss { get; set; }
        public double OnTime { get; set; }
        public int CachedOnTimeType { get; set; }
        public double EnergyContent { get; set; }
        public double TechnicalWi { get; set; }
        public double RemainingSalesGas { get; set; }
        public double Rgip { get; set; }
        public byte HasVolumetrics { get; set; }
        public DateTime? ActualForecastStart { get; set; }
    }
}
