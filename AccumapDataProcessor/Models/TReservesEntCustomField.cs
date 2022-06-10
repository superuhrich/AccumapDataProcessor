using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TReservesEntCustomField
    {
        public string ParentId { get; set; } = null!;
        public string UserFieldId { get; set; } = null!;
        public string? StringValue { get; set; }
        public double? NumericValue { get; set; }
        public DateTime? DateValue { get; set; }
    }
}
