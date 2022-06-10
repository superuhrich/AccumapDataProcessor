using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TCtrlMetrixEtlVariable
    {
        public string? VariableName { get; set; }
        public string? VariableValue { get; set; }
        public string? CubeName { get; set; }
        public string? DimensionName { get; set; }
        public string? DimensionMember { get; set; }
        public string? Target1Name { get; set; }
        public string? Target2Value { get; set; }
        public string? Comments { get; set; }
        public DateTime? DateValue { get; set; }
        public int? IntValue { get; set; }
    }
}
