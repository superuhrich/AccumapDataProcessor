using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class VRptRoyaltyObligation
    {
        public string? ProductionDate { get; set; }
        public string? ControlGroupId { get; set; }
        public string? WellTractId { get; set; }
        public string? WellTractName { get; set; }
        public string RoyaltyObligationId { get; set; } = null!;
        public string? RoyaltyOwnerId { get; set; }
        public string? RoyaltyOwnerName { get; set; }
        public string? RoyaltyType { get; set; }
        public string? PaymentType { get; set; }
        public string ProductCode { get; set; } = null!;
        public string? RoyaltyFormulaId { get; set; }
        public string? FormulaDescription { get; set; }
        public string? RoyaltyGlobalFactorId { get; set; }
        public string? FactorDescription { get; set; }
        public decimal? Factor { get; set; }
        public string? RequiredFlag { get; set; }
        public decimal WellTractSysId { get; set; }
    }
}
