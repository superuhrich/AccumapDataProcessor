using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TTypecurvesEntReversionInterest
    {
        public string ObjectId { get; set; } = null!;
        public string ParentId { get; set; } = null!;
        public int? SortIndex { get; set; }
        public double? WorkingInterest { get; set; }
        public double? OpCostInterest { get; set; }
        public double? CapCostInterest { get; set; }
        public double? FacilityInterest { get; set; }
        public double? FreeholdInterestReceivable { get; set; }
        public double? GorReceivable { get; set; }
        public double? NorReceivable { get; set; }
        public double? NpiReceivable { get; set; }
        public double? GorPayable { get; set; }
        public double? NorPayable { get; set; }
        public double? NpiPayable { get; set; }
        public double? PoolingFactor { get; set; }
        public double? TractFactor { get; set; }
        public double? RoyaltyFactor { get; set; }
        public double? RoyaltyDeduction { get; set; }
        public int? ReversionType { get; set; }
        public double? ReversionValue { get; set; }
        public DateTime? ReversionDate { get; set; }
        public double? GorDeductionPayable { get; set; }
        public double? GorDeductionReceivable { get; set; }
    }
}
