using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class RoyaltyObligationMaster
    {
        public string? CreateUser { get; set; }
        public string? CreateProgram { get; set; }
        public DateTime? CreateDateTime { get; set; }
        public string? LastUpdateUser { get; set; }
        public string? LastUpdateProgram { get; set; }
        public DateTime? LastUpdateDateTime { get; set; }
        public decimal? LastUpdateAuditId { get; set; }
        public decimal? Version { get; set; }
        public decimal? SysId { get; set; }
        public decimal? ProductionDate { get; set; }
        public string? ObligationType { get; set; }
        public string? TakenInKind { get; set; }
        public decimal? DoiOwnershipExtensionId { get; set; }
        public string? PaymentType { get; set; }
        public string? TaxType { get; set; }
        public string? UserDefined1 { get; set; }
        public string? UserDefined2 { get; set; }
        public string? UserDefined3 { get; set; }
        public decimal? RoyaltyObligationSysId { get; set; }
        public string? RoyaltyFormulaId { get; set; }
        public string? RoyaltyOwnerId { get; set; }
        public string? PaidByOwnerId { get; set; }
        public string? PayorType { get; set; }
        public string? ActiveFlag { get; set; }
        public decimal? RoyaltyEntitySysId { get; set; }
    }
}
