using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TIhsXrefStatus
    {
        public string? Code { get; set; }
        public string? Source { get; set; }
        public string? SourceCode { get; set; }
        public string? Abrev { get; set; }
        public string? Name { get; set; }
        public string? PlotSymbol { get; set; }
        public string? V80cCode { get; set; }
        public string? V80cName { get; set; }
        public string? V80cPlotSymbol { get; set; }
        public string? IhseCode { get; set; }
        public string? IhseName { get; set; }
        public string? IhsePlotSymbol { get; set; }
        public string? PetraFluid { get; set; }
        public string? RowCreatedBy { get; set; }
        public DateTime? RowCreatedDate { get; set; }
        public string? RowChangedBy { get; set; }
        public DateTime? RowChangedDate { get; set; }
        public string? PetraMode { get; set; }
    }
}
