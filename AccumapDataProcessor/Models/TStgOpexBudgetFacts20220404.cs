using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TStgOpexBudgetFacts20220404
    {
        public string? DataSource { get; set; }
        public string? Scenario { get; set; }
        public string? BudgetGroup { get; set; }
        public string? MajorAcct { get; set; }
        public string? MinorAcct { get; set; }
        public string? Measure { get; set; }
        public string? GrsNetFlag { get; set; }
        public string? BudgetYear { get; set; }
        public decimal? January { get; set; }
        public decimal? February { get; set; }
        public decimal? March { get; set; }
        public decimal? April { get; set; }
        public decimal? May { get; set; }
        public decimal? June { get; set; }
        public decimal? July { get; set; }
        public decimal? August { get; set; }
        public decimal? September { get; set; }
        public decimal? October { get; set; }
        public decimal? November { get; set; }
        public decimal? December { get; set; }
        public string? Filename { get; set; }
    }
}
