using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TQbyteProduct
    {
        public DateTime? CreateDate { get; set; }
        public string? CreateUser { get; set; }
        public string? ProdCode { get; set; }
        public string? ProdName { get; set; }
        public string? ActualMeasureSystemCode { get; set; }
        public string? BudgetMeasureSystemCode { get; set; }
        public string? ProdShortName { get; set; }
        public string? SiUnit { get; set; }
        public string? ImperialUnit { get; set; }
        public decimal? SiToImpConvFactor { get; set; }
        public string? SalesMajorAcct { get; set; }
        public string? SalesMinorAcct { get; set; }
        public decimal? BoeThermal { get; set; }
        public decimal? BoeEconomic { get; set; }
        public decimal? M3Thermal { get; set; }
        public string? EnergySiUnit { get; set; }
        public string? EnergyImperialUnit { get; set; }
        public decimal? EnergySiToImpConvFactor { get; set; }
        public decimal? Mcfe6Thermal { get; set; }
        public string? LastUpdateUser { get; set; }
        public DateTime? LastUpdateDate { get; set; }
    }
}
