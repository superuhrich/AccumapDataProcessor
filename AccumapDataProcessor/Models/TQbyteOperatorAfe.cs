using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TQbyteOperatorAfe
    {
        public DateTime? CreateDate { get; set; }
        public string? CreateUser { get; set; }
        public string? AfeNum { get; set; }
        public decimal? ClientId { get; set; }
        public string? OperatorAfeNum { get; set; }
        public string? LastUpdateUser { get; set; }
        public DateTime? LastUpdateDate { get; set; }
    }
}
