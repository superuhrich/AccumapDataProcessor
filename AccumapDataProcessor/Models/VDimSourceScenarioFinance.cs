using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class VDimSourceScenarioFinance
    {
        public string? ScenarioKey { get; set; }
        public string? ScenarioParentKey { get; set; }
        public string? ScenarioDescription { get; set; }
        public string? ScenarioCubeName { get; set; }
        public string? UnaryOperator { get; set; }
        public string? ScenarioFormula { get; set; }
        public string? ScenarioFormulaProperty { get; set; }
        public string? ScenarioLevel01 { get; set; }
        public string? ScenarioLevel02 { get; set; }
        public string? ScenarioLevel03 { get; set; }
        public string? ScenarioLevel04 { get; set; }
        public string? ScenarioLevel05 { get; set; }
        public string? ScenarioLevel01SortKey { get; set; }
        public string? ScenarioLevel02SortKey { get; set; }
        public string? ScenarioLevel03SortKey { get; set; }
        public string? ScenarioLevel04SortKey { get; set; }
        public string? ScenarioLevel05SortKey { get; set; }
        public string HierarchyType { get; set; } = null!;
    }
}
