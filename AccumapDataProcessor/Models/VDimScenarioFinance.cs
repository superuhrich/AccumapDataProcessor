using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class VDimScenarioFinance
    {
        public string? ScenarioKey { get; set; }
        public string? ScenarioDescription { get; set; }
        public string? ScenarioCubeName { get; set; }
        public string? UnaryOperator { get; set; }
        public string? ScenarioFormula { get; set; }
        public string? ScenarioFormulaProperty { get; set; }
        public string? PostedLevel01 { get; set; }
        public string? PostedLevel02 { get; set; }
        public string? PostedLevel03 { get; set; }
        public string? PostedLevel04 { get; set; }
        public string? PostedLevel05 { get; set; }
        public string? PostedLevel01SortKey { get; set; }
        public string? PostedLevel02SortKey { get; set; }
        public string? PostedLevel03SortKey { get; set; }
        public string? PostedLevel04SortKey { get; set; }
        public string? PostedLevel05SortKey { get; set; }
        public string? UnpostedLevel01 { get; set; }
        public string? UnpostedLevel02 { get; set; }
        public string? UnpostedLevel03 { get; set; }
        public string? UnpostedLevel04 { get; set; }
        public string? UnpostedLevel05 { get; set; }
        public string? UnpostedLevel01SortKey { get; set; }
        public string? UnpostedLevel02SortKey { get; set; }
        public string? UnpostedLevel03SortKey { get; set; }
        public string? UnpostedLevel04SortKey { get; set; }
        public string? UnpostedLevel05SortKey { get; set; }
        public string? UnpostedScenarioKey { get; set; }
    }
}
