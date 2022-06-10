using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class VOpexPwrappsScenario
    {
        public string? Scenario { get; set; }
        public string? Parent { get; set; }
        public string SourceFlag { get; set; } = null!;
        public string TargetFlag { get; set; } = null!;
    }
}
