using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class CBase
    {
        public string FileNumber { get; set; } = null!;
        public string AdminCompany { get; set; } = null!;
        public string? ContractName { get; set; }
        public string? FileStatus { get; set; }
        public DateTime? StatusDate { get; set; }
        public string ContractType { get; set; } = null!;
        public DateTime ContractDate { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public string? RevisionNumber { get; set; }
        public DateTime? RevisionDate { get; set; }
        public string? UnitOperator { get; set; }
        public string? UnitCode { get; set; }
        public string? PrevDocNumber { get; set; }
        public DateTime? TerminationDate { get; set; }
        public string? Term { get; set; }
        public string? TermNotice { get; set; }
        public string? Producer { get; set; }
        public string? Processor { get; set; }
        public string? Rofr { get; set; }
        public string? Assignment { get; set; }
        public string? AssignmentTerms { get; set; }
        public string Segregation { get; set; } = null!;
    }
}
