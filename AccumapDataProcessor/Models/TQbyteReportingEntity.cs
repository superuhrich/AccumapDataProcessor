using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TQbyteReportingEntity
    {
        public decimal? ReportingEntityId { get; set; }
        public string? HierarchyCode { get; set; }
        public string? ReportingLevelCode { get; set; }
        public string? ReportingEntityCode { get; set; }
        public string? ReportingEntityDesc { get; set; }
        public string? ParentReportingEntityCode { get; set; }
        public string? ParentReportingLevelCode { get; set; }
        public string? CcNum { get; set; }
        public string? ReportingEntityLocation { get; set; }
        public decimal? ParentReportingEntityId { get; set; }
        public string? AfeNum { get; set; }
        public decimal? OrgId { get; set; }
        public string? MajorAcct { get; set; }
        public string? MinorAcct { get; set; }
        public string? OtherId { get; set; }
        public string? ContinuityCode { get; set; }
        public string? CreateUser { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? LastUpdateUser { get; set; }
        public DateTime? LastUpdateDate { get; set; }
    }
}
