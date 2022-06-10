using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TQbyteDoiDeck
    {
        public DateTime? CreateDate { get; set; }
        public string? CreateUser { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public string? LastUpdateUser { get; set; }
        public decimal? Id { get; set; }
        public string? Name { get; set; }
        public string? TerminateFlag { get; set; }
        public decimal? BillingAgentBaId { get; set; }
        public DateTime? TermDate { get; set; }
        public string? TermUser { get; set; }
    }
}
