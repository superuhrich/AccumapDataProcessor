using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class DoiMaster
    {
        public string? CreateUser { get; set; }
        public string? CreateProgram { get; set; }
        public DateTime? CreateDateTime { get; set; }
        public string? LastUpdateUser { get; set; }
        public string? LastUpdateProgram { get; set; }
        public DateTime? LastUpdateDateTime { get; set; }
        public decimal? LastUpdateAuditId { get; set; }
        public decimal? Version { get; set; }
        public decimal? SysId { get; set; }
        public string? SubId { get; set; }
        public decimal? EffectiveDate { get; set; }
        public string? UserDefined1 { get; set; }
        public string? DefaultDoi { get; set; }
        public decimal? DivisionOfInterestSysId { get; set; }
    }
}
