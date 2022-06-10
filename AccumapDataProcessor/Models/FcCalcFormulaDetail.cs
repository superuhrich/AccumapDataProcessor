using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class FcCalcFormulaDetail
    {
        public decimal SysId { get; set; }
        public string CreateUser { get; set; } = null!;
        public DateTime CreateDateTime { get; set; }
        public decimal ProductionDate { get; set; }
        public decimal? JobId { get; set; }
        public string? FacilityType { get; set; }
        public string? FacilityId { get; set; }
        public string? ProductCode { get; set; }
        public string? ChargeFacilityType { get; set; }
        public string? ChargeFacilityId { get; set; }
        public string? ChargeType { get; set; }
        public decimal? FcSequenceNumber { get; set; }
        public string? OwnerId { get; set; }
        public string? FormulaId { get; set; }
        public decimal? SequenceNumber { get; set; }
        public string? CalculationDescription { get; set; }
        public decimal? Factor { get; set; }
        public string? PercentFlag { get; set; }
        public decimal? Minimum { get; set; }
        public decimal? Maximum { get; set; }
        public string? ResultSign { get; set; }
        public decimal? ResultFactor { get; set; }
        public decimal? Subtotal { get; set; }
        public string? ControlGroupId { get; set; }
    }
}
