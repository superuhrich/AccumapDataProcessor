using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class UserAccount
    {
        public string CreateUser { get; set; } = null!;
        public string? CreateProgram { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string LastUpdateUser { get; set; } = null!;
        public string? LastUpdateProgram { get; set; }
        public DateTime LastUpdateDateTime { get; set; }
        public decimal? LastUpdateAuditId { get; set; }
        public decimal Version { get; set; }
        public string UserId { get; set; } = null!;
        public string UserName { get; set; } = null!;
        public string InactiveUser { get; set; } = null!;
        public string AllControlGroupAccess { get; set; } = null!;
        public decimal? HomePageSysId { get; set; }
        public string DefaultExpandAllFlag { get; set; } = null!;
        public decimal? DefaultProductionDate { get; set; }
        public string? DefaultControlGroupId { get; set; }
    }
}
