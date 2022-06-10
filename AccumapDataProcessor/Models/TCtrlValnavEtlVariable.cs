using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TCtrlValnavEtlVariable
    {
        public string? VariableName { get; set; }
        public string? VariableValue { get; set; }
        public string? Comments { get; set; }
        public string? CubeDimension { get; set; }
        public string? CubeChildMember { get; set; }
        public string? SignFlipFlag { get; set; }
        public string? ArchiveScenario { get; set; }
        public DateTime? DateValue { get; set; }
        public int? IntValue { get; set; }
        public string? Text1 { get; set; }
        public string? Text2 { get; set; }
        public string? Description { get; set; }
    }
}
