using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TQbyteAfesCostCentre
    {
        public DateTime? CreateDate { get; set; }
        public string? CreateUser { get; set; }
        public string? AfeNum { get; set; }
        public string? CcNum { get; set; }
        public string? LastUpdateUser { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public string? CreateProgram { get; set; }
        public decimal? LastUpdateAuditId { get; set; }
    }
}
