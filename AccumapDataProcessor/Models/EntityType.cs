using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class EntityType
    {
        public string CreateUser { get; set; } = null!;
        public string? CreateProgram { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string LastUpdateUser { get; set; } = null!;
        public string? LastUpdateProgram { get; set; }
        public DateTime LastUpdateDateTime { get; set; }
        public decimal? LastUpdateAuditId { get; set; }
        public decimal Version { get; set; }
        public string Description { get; set; } = null!;
        public string? ShortDescription { get; set; }
        public decimal? SortOrder { get; set; }
        public string ActiveValue { get; set; } = null!;
        public string Code { get; set; } = null!;
        public string? FacilityType { get; set; }
        public string? WellTractType { get; set; }
        public string? UnitType { get; set; }
        public string? DeliveryType { get; set; }
        public string? OwnerType { get; set; }
        public string? OperatedType { get; set; }
        public string? IndianReserveUsage { get; set; }
        public string? ChargeFacilityUsage { get; set; }
        public string? VoucherUsage { get; set; }
        public string? ParticipantGroupUsage { get; set; }
        public string? IpsParticipantUsage { get; set; }
    }
}
