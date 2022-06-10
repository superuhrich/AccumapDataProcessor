using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class DoiOwner
    {
        public string? CreateUser { get; set; }
        public DateTime? CreateDateTime { get; set; }
        public string? LastUpdateUser { get; set; }
        public DateTime? LastUpdateDateTime { get; set; }
        public decimal? Version { get; set; }
        public decimal? SysId { get; set; }
        public decimal? OwnerInterestPercent { get; set; }
        public string? GstForFacilityCharges { get; set; }
        public string? ExcludeOwner { get; set; }
        public string? OwnerId { get; set; }
        public decimal? DoiMasterSysId { get; set; }
        public string? CreateProgram { get; set; }
        public string? LastUpdateProgram { get; set; }
        public decimal? LastUpdateAuditId { get; set; }
        public string? SilentPartnerParentId { get; set; }
    }
}
