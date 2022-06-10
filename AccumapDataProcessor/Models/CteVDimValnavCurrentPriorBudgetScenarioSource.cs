using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class CteVDimValnavCurrentPriorBudgetScenarioSource
    {
        public int? Xlevel { get; set; }
        public string? ScenarioCubeName { get; set; }
        public string? ScenarioKey { get; set; }
        public string? ScenarioParentKey { get; set; }
        public string? ScenarioDescription { get; set; }
        public string? ScenarioSortKey { get; set; }
        public string? SourceReplaceText { get; set; }
        public string? DestReplaceText { get; set; }
    }
}
