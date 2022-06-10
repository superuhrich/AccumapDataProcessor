using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TTypecurvesResultsRegime
    {
        public string ResultId { get; set; } = null!;
        public DateTime StepDate { get; set; }
        public double AdValorem { get; set; }
        public double AdValoremBasis { get; set; }
        public double BasicTax { get; set; }
        public double Bonus { get; set; }
        public double CostRecovery { get; set; }
        public double Credits { get; set; }
        public double Dda { get; set; }
        public double DesignatedRor { get; set; }
        public double Dmo { get; set; }
        public double Expense { get; set; }
        public double Income { get; set; }
        public double InvestmentCredits { get; set; }
        public double ProfitRevenue { get; set; }
        public double Royalty { get; set; }
        public double ServiceFee { get; set; }
        public double Severance { get; set; }
        public double Tranche { get; set; }
        public double Uplift { get; set; }
    }
}
