using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class UnitMaster
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
        public string Name { get; set; } = null!;
        public string GovernmentCode { get; set; } = null!;
        public string? CostCentreCode { get; set; }
        public string? UserDefined1 { get; set; }
        public string? UserDefined2 { get; set; }
        public decimal? ThirdTierEorFactor { get; set; }
        public string? CalculationLevel { get; set; }
        public decimal? RoyaltyEntitySysId { get; set; }
        public decimal? OilRoyaltyEntitySysId { get; set; }
        public string FacilityOperatorId { get; set; } = null!;
        public string PaResponsibleUserId { get; set; } = null!;
        public string UnitId { get; set; } = null!;
        public string MineralOwnershipAtTracFlag { get; set; } = null!;
        public string AdjustingBaseVolumeFlag { get; set; } = null!;
    }
}
