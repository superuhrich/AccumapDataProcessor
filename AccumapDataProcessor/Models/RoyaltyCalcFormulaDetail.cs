using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class RoyaltyCalcFormulaDetail
    {
        public decimal? SysId { get; set; }
        public string? CreateUser { get; set; }
        public DateTime? CreateDateTime { get; set; }
        public decimal? ProductionDate { get; set; }
        public decimal? JobId { get; set; }
        public string? RecordType { get; set; }
        public string? FacilityType { get; set; }
        public string? FacilityId { get; set; }
        public string? WellTractType { get; set; }
        public string? WellTractId { get; set; }
        public string? ObligationId { get; set; }
        public decimal? SequenceNumber { get; set; }
        public string? CalculationDescription { get; set; }
        public decimal? Factor { get; set; }
        public string? PercentFlag { get; set; }
        public decimal? Minimum { get; set; }
        public decimal? Maximum { get; set; }
        public string? ResultSign { get; set; }
        public decimal? ResultFactor { get; set; }
        public decimal? Subtotal { get; set; }
        public string? Product { get; set; }
        public string? RonProduct { get; set; }
    }
}
