using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TRptCsxLatestWorkingInterest
    {
        public string FileNumber { get; set; } = null!;
        public string? Uwi { get; set; }
        public string FileStatus { get; set; } = null!;
        public string? CsxCostCentre { get; set; }
        public string WellStatus { get; set; } = null!;
        public string? LicenceNumber { get; set; }
        public DateTime EffectiveDate { get; set; }
        public DateTime? TerminationDate { get; set; }
        public DateTime OriginalTerminationDate { get; set; }
        public string? PartnerId { get; set; }
        public int? FormattedPartnerId { get; set; }
        public string? Name { get; set; }
        public string? PartnerType { get; set; }
        public string DoiType { get; set; } = null!;
        public string NetOwner { get; set; } = null!;
        public decimal? CsxOwnershipPercent { get; set; }
        public decimal? CsxTotalWellWrkngIntrst { get; set; }
        public long? PctRnk { get; set; }
    }
}
