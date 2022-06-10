using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class VStgQbyteCostCentreDoi
    {
        public decimal? AgreementId { get; set; }
        public decimal? BaId { get; set; }
        public string? BaName { get; set; }
        public string? BaTypeCode { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public DateTime TerminationDate { get; set; }
        public DateTime? OriginalExpiryDate { get; set; }
        public string? CcNum { get; set; }
        public decimal? Doi { get; set; }
    }
}
