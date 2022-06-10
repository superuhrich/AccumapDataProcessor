using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TBasedeclineResultsBtax
    {
        public string ResultId { get; set; } = null!;
        public DateTime StepDate { get; set; }
        public byte IsAnnual { get; set; }
        public int MonthsInStep { get; set; }
        public double DaysInStep { get; set; }
        public double ProducingDays { get; set; }
        public double GrossWellCount { get; set; }
        public double WiWellCount { get; set; }
        public double GrossProdWellCount { get; set; }
        public double WiProdWellCount { get; set; }
        public double GrossRevenue { get; set; }
        public double WiRevenue { get; set; }
        public double RiRevenue { get; set; }
        public double FiRevenue { get; set; }
        public double NetRevenue { get; set; }
        public double RoyBasisGrossRevenue { get; set; }
        public double RoyBasisWiRevenue { get; set; }
        public double RoyBasisFiRevenue { get; set; }
        public double SuccessNetRevenue { get; set; }
        public double FailureNetRevenue { get; set; }
        public double SuccessCap { get; set; }
        public double FailureCap { get; set; }
        public double RoyGrCrown { get; set; }
        public double RoyAdjCrown { get; set; }
        public double RoyGrIndian { get; set; }
        public double RoyAdjIndian { get; set; }
        public double RoyGrFreehold { get; set; }
        public double RoyAdjFreehold { get; set; }
        public double RoyMineralTax { get; set; }
        public double RoyGrGor { get; set; }
        public double RoyAdjGor { get; set; }
        public double RoyGrOtherOverrides { get; set; }
        public double RoyAdjOtherOverrides { get; set; }
        public double RoyGrNpi { get; set; }
        public double RoyAdjNpi { get; set; }
        public double RoyAdjTotal { get; set; }
        public double SaskCapSurcharge { get; set; }
        public double TaxCredit { get; set; }
        public double AdValorem { get; set; }
        public double Severance { get; set; }
        public double NetOpIncome { get; set; }
        public double NetOpIncomeNpv1 { get; set; }
        public double NetOpIncomeNpv2 { get; set; }
        public double NetOpIncomeNpv3 { get; set; }
        public double NetOpIncomeNpv4 { get; set; }
        public double NetOpIncomeNpv5 { get; set; }
        public double Npv1 { get; set; }
        public double Npv2 { get; set; }
        public double Npv3 { get; set; }
        public double Npv4 { get; set; }
        public double Npv5 { get; set; }
    }
}
