using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TCtrlEtlVariable2
    {
        public string? VariableName { get; set; }
        public string? VariableValue { get; set; }
        public string? Comments { get; set; }
        public DateTime? DateValue { get; set; }
        public int? IntValue { get; set; }
    }
}
