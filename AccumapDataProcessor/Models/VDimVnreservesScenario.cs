using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class VDimVnreservesScenario
    {
        public string? ScenarioKey { get; set; }
        public string? ScenarioParentKey { get; set; }
        public string? ScenarioDescription { get; set; }
        public string? ScenarioCubeName { get; set; }
        public string? UnaryOperator { get; set; }
        public string? ScenarioFormula { get; set; }
        public string? ScenarioFormulaProperty { get; set; }
        public string? ScenarioSortKey { get; set; }
    }
}
