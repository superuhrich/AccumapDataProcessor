using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class VValnavTypeCurvesUwiWorkingInterest
    {
        public string? Uwi { get; set; }
        public string? EntityObjectId { get; set; }
        public string ReversionInterestObjectId { get; set; } = null!;
        public string ReversionInterestParentId { get; set; } = null!;
        public DateTime EffectiveDate { get; set; }
        public DateTime? NextEffectiveDate { get; set; }
        public double? WorkingInterest { get; set; }
        public double? TractWorkingInterest { get; set; }
        public double? OpCostInterest { get; set; }
        public double? CapCostInterest { get; set; }
        public double? FacilityInterest { get; set; }
        public double? FreeholdInterestReceivable { get; set; }
        public double? GorReceivable { get; set; }
        public double? NorReceivable { get; set; }
        public double? TractFactor { get; set; }
        public double? PoolingFactor { get; set; }
        public double? RoyaltyFactor { get; set; }
        public int? SortIndex { get; set; }
        public DateTime? ReservesRealizedDate { get; set; }
        public string IsReservesRealizedWi { get; set; } = null!;
        public double? RoyaltyIncomeInterest { get; set; }
        public double? ChanceOfSuccess { get; set; }
        public string? PrimaryProduct { get; set; }
        public double? DepthGci { get; set; }
    }
}
