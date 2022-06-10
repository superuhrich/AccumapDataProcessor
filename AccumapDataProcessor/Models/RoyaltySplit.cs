using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class RoyaltySplit
    {
        public string CreateUser { get; set; } = null!;
        public string? CreateProgram { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string LastUpdateUser { get; set; } = null!;
        public string? LastUpdateProgram { get; set; }
        public DateTime LastUpdateDateTime { get; set; }
        public decimal? LastUpdateAuditId { get; set; }
        public decimal Version { get; set; }
        public decimal SysId { get; set; }
        public decimal ProductionDate { get; set; }
        public string ObligationType { get; set; } = null!;
        public decimal? RoyaltyValue { get; set; }
        public decimal? RoyaltyVolume { get; set; }
        public string? ShareType { get; set; }
        public string? PaymentType { get; set; }
        public decimal? WorkingInterest { get; set; }
        public string? RoyaltyHoliday { get; set; }
        public decimal? ObligationTotalValue { get; set; }
        public decimal? ObligationTotalVolume { get; set; }
        public string? CrownClassification { get; set; }
        public string? UnitizationType { get; set; }
        public string? DoiSubUsed { get; set; }
        public decimal? WorkingInterestPercent { get; set; }
        public string? SilentPartnerOwner { get; set; }
        public string? TaxType { get; set; }
        public decimal? GrossNrt { get; set; }
        public string? ReportAsCondensate { get; set; }
        public decimal? CrownAdjustmentValue { get; set; }
        public string? WellUserDefined1 { get; set; }
        public string? BatteryFacilityId { get; set; }
        public string? ControlGroupId { get; set; }
        public decimal? RoyaltyObligationSysId { get; set; }
        public decimal? FacilitySysId { get; set; }
        public string DoiOwnerId { get; set; } = null!;
        public string? RoyaltyOwnerId { get; set; }
        public decimal WellTractSysId { get; set; }
        public string? ProductCode { get; set; }
        public string? UnitId { get; set; }
        public decimal? RoyaltyNrtValue { get; set; }
        public decimal? RoyaltyNrtVolume { get; set; }
        public decimal? GrossNrtVolume { get; set; }
    }
}
