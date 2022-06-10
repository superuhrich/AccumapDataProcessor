using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TStgOpexAccrualsXl
    {
        public string? SourceFile { get; set; }
        public string? Area { get; set; }
        public string? Accounts { get; set; }
        public string? Scenario { get; set; }
        public string? AccountingMonth { get; set; }
        public double? Amount { get; set; }
    }
}
