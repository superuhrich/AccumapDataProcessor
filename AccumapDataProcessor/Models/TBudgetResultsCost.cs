using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TBudgetResultsCost
    {
        public string ResultId { get; set; } = null!;
        public DateTime StepDate { get; set; }
        public double OpWiGrFixed { get; set; }
        public double OpWiWiFixed { get; set; }
        public double OpWiGrVariable { get; set; }
        public double OpWiWiVariable { get; set; }
        public double OpFiGrFixed { get; set; }
        public double OpFiWiVariable { get; set; }
        public double OpFiGrVariable { get; set; }
        public double OpFiWiFixed { get; set; }
        public double OpGrOtherRevenue { get; set; }
        public double OpWiOtherRevenue { get; set; }
        public double CapGrCanExploration { get; set; }
        public double CapWiCanExploration { get; set; }
        public double CapGrCanDevelopment { get; set; }
        public double CapWiCanDevelopment { get; set; }
        public double CapGrCanAllowance { get; set; }
        public double CapWiCanAllowance { get; set; }
        public double CapGrCanProperty { get; set; }
        public double CapWiCanProperty { get; set; }
        public double CapGrUsTangible { get; set; }
        public double CapWiUsTangible { get; set; }
        public double CapGrUsIntangible { get; set; }
        public double CapWiUsIntangible { get; set; }
        public double CapGrUsPropLease { get; set; }
        public double CapWiUsPropLease { get; set; }
        public double CapGrUsGg { get; set; }
        public double CapWiUsGg { get; set; }
        public double CapGrAbandonment { get; set; }
        public double CapWiAbandonment { get; set; }
        public double CapGrSalvage { get; set; }
        public double CapWiSalvage { get; set; }
        public double CapGrOther { get; set; }
        public double CapWiOther { get; set; }
        public double CapUnriskedCanExploration { get; set; }
        public double CapUnriskedCanDevelopment { get; set; }
        public double CapUnriskedCanAllowance { get; set; }
        public double CapUnriskedCanProperty { get; set; }
        public double CapUnriskedUsTangible { get; set; }
        public double CapUnriskedUsIntangible { get; set; }
        public double CapUnriskedUsPropLease { get; set; }
        public double CapUnriskedUsGg { get; set; }
        public double CapUnriskedAbandonment { get; set; }
        public double CapUnriskedSalvage { get; set; }
    }
}
