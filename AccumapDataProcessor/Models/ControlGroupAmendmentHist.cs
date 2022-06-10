using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class ControlGroupAmendmentHist
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
        public string? ControlGroupId { get; set; }
        public DateTime? RequestedDateTime { get; set; }
        public string? RequestedByUser { get; set; }
        public string? AmendmentReason { get; set; }
        public string? OpenFromStepNumber { get; set; }
        public string? AssignedToUser { get; set; }
        public DateTime? ScheduledDateTime { get; set; }
        public string? ScheduledByUser { get; set; }
        public DateTime? ClosedDateTime { get; set; }
        public string? ClosedByUser { get; set; }
        public decimal? ClosedAccountingDate { get; set; }
        public string? ResetAllFacilitiesFlag { get; set; }
    }
}
