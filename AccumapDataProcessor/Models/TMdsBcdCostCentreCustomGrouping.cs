using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TMdsBcdCostCentreCustomGrouping
    {
        public int Id { get; set; }
        public Guid Muid { get; set; }
        public string VersionName { get; set; } = null!;
        public int VersionNumber { get; set; }
        public int VersionId { get; set; }
        public string? VersionFlag { get; set; }
        public string? Name { get; set; }
        public string Code { get; set; } = null!;
        public int ChangeTrackingMask { get; set; }
        public string? CostCentreType { get; set; }
        public string? Group1 { get; set; }
        public string? Group2 { get; set; }
        public string? Group3 { get; set; }
        public string? Group4 { get; set; }
        public string? Group5 { get; set; }
        public string? Group6 { get; set; }
        public string? Group7 { get; set; }
        public string? Group8 { get; set; }
        public string? Group9 { get; set; }
        public string? Group10 { get; set; }
        public DateTime EnterDateTime { get; set; }
        public string? EnterUserName { get; set; }
        public int? EnterVersionNumber { get; set; }
        public DateTime LastChgDateTime { get; set; }
        public string? LastChgUserName { get; set; }
        public int? LastChgVersionNumber { get; set; }
        public string? ValidationStatus { get; set; }
    }
}
