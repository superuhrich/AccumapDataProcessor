using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class DivisionOfInterest
    {
        public string? CreateUser { get; set; }
        public DateTime? CreateDateTime { get; set; }
        public string? LastUpdateUser { get; set; }
        public DateTime? LastUpdateDateTime { get; set; }
        public decimal? Version { get; set; }
        public decimal? SysId { get; set; }
        public string? CreateProgram { get; set; }
        public string? LastUpdateProgram { get; set; }
        public decimal? LastUpdateAuditId { get; set; }
        public decimal? FacilitySysId { get; set; }
        public decimal? WellTractSysId { get; set; }
        public string? UnitId { get; set; }
    }
}
