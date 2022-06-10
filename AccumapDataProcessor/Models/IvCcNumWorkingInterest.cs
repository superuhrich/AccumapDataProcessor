using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class IvCcNumWorkingInterest
    {
        public string? CcNum { get; set; }
        public decimal? WorkingInterest { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public DateTime TerminationDate { get; set; }
    }
}
