using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class VRptWiExceptionQbC
    {
        public string? Uwi { get; set; }
        public string? CostCentre { get; set; }
        public decimal? PartnerId { get; set; }
        public string? PartnerName { get; set; }
        public decimal? QbyteWorkingInterest { get; set; }
        public decimal? CsxWorkingInterest { get; set; }
        public int? NumMismatches { get; set; }
        public decimal? QbyteTotalWi { get; set; }
        public decimal? CsxTotalWi { get; set; }
        public string? CcTypeCode { get; set; }
        public string? CostCentreName { get; set; }
        public string? DistrictCode { get; set; }
        public string? OpNonop { get; set; }
        public string? FileNumber { get; set; }
        public string? FileStatus { get; set; }
        public string? WellStatus { get; set; }
        public string? ExceptionType { get; set; }
    }
}
