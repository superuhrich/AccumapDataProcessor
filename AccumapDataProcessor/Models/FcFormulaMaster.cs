using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class FcFormulaMaster
    {
        public string CreateUser { get; set; } = null!;
        public string? CreateProgram { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string LastUpdateUser { get; set; } = null!;
        public string? LastUpdateProgram { get; set; }
        public DateTime LastUpdateDateTime { get; set; }
        public decimal? LastUpdateAuditId { get; set; }
        public decimal Version { get; set; }
        public decimal SysId { get; set; }
        public decimal ProductionDate { get; set; }
        public string Description { get; set; } = null!;
        public string PrimaryRetrievalCode { get; set; } = null!;
        public string VolumeType { get; set; } = null!;
        public string ValueType { get; set; } = null!;
        public string? UnitTractCriteria { get; set; }
        public string FacilityChargeFormulaId { get; set; } = null!;
        public string? FcShutinLookupId { get; set; }
        public string FacilityChargeFormulaType { get; set; } = null!;
        public string? ControlGroupId { get; set; }
        public string? FcMonthlyInputId { get; set; }
    }
}
