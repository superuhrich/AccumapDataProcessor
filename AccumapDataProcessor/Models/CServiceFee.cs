using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class CServiceFee
    {
        public string FileNumber { get; set; } = null!;
        public decimal LocOccurrence { get; set; }
        public decimal FeeOccurrence { get; set; }
        public decimal HistOccurrence { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public DateTime? TerminationDate { get; set; }
        public string? ProcWl { get; set; }
        public string? ProcWellNumber { get; set; }
        public string? ProcUwi { get; set; }
        public string? ProcSortedUwi { get; set; }
        public string? ProcDescription { get; set; }
        public string? ProcProject { get; set; }
        public string? ServiceType { get; set; }
        public DateTime? ServiceTermDate { get; set; }
        public decimal? FeeCapital { get; set; }
        public decimal? FeeOperating { get; set; }
        public string? FeeBasis { get; set; }
        public DateTime? FeeEffectDate { get; set; }
        public DateTime? InputDate { get; set; }
        public string? ReasonForChange { get; set; }
        public string? AscYn { get; set; }
        public string? GrossNetGn { get; set; }
        public string? PaFacilityId { get; set; }
        public string? VolumeBasisGis { get; set; }
        public string VariableFee { get; set; } = null!;
        public string? Comments { get; set; }
        public string? DpUwi { get; set; }
        public string? DpDesc { get; set; }
        public string? ApUwi { get; set; }
        public string? ApDesc { get; set; }
        public string? CostCentreNum { get; set; }
        public decimal? NetPct { get; set; }
    }
}
