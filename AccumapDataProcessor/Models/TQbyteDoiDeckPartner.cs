using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TQbyteDoiDeckPartner
    {
        public decimal? DoiDeckId { get; set; }
        public decimal? PartnerBaId { get; set; }
        public decimal? LaPartnerPct { get; set; }
        public decimal? FmPartnerPct { get; set; }
        public string? SilentPartnerFlag { get; set; }
        public string? AccountableFlag { get; set; }
        public string? TakeInKindFlag { get; set; }
        public string? PenaltyFlag { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? CreateUser { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public string? LastUpdateUser { get; set; }
        public decimal? SilentAgentBaId { get; set; }
    }
}
