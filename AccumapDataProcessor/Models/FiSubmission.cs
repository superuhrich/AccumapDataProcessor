using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class FiSubmission
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
        public decimal? AccountingDate { get; set; }
        public decimal? JobId { get; set; }
        public DateTime? SubmitDateTime { get; set; }
        public string? ProcessError { get; set; }
        public string? SubmitUser { get; set; }
        public decimal? ProductionDate { get; set; }
        public string? ControlGroupId { get; set; }
        public string? FinancialGroupId { get; set; }
        public string? RegionId { get; set; }
        public string? TransactionType { get; set; }
        public string? CompanyNumber { get; set; }
        public string? BatchOption { get; set; }
        public string? DetailCsvFiles { get; set; }
        public string? RunType { get; set; }
        public string? IncludeAmendments { get; set; }
        public string? IncludeNetZeroRecords { get; set; }
        public string? FiIdentifierId { get; set; }
    }
}
