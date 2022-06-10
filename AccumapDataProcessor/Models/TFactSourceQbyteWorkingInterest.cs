using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TFactSourceQbyteWorkingInterest
    {
        public string Account { get; set; } = null!;
        public int AccountingPeriod { get; set; }
        public int ActivityPeriod { get; set; }
        public string? EntityKey { get; set; }
        public int? CreateDate { get; set; }
        public int? OnProductionDate { get; set; }
        public int? LastProductionDate { get; set; }
        public int? RigReleaseDate { get; set; }
        public int? SpudDate { get; set; }
        public int? CcTermDate { get; set; }
        public string Scenario { get; set; } = null!;
        public string? OpNonop { get; set; }
        public string? BudgetGroup { get; set; }
        public decimal? WorkingInterest { get; set; }
    }
}
