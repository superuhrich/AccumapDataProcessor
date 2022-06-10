using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TReservesCodeLookup
    {
        public string? CodeType { get; set; }
        public int? CodeValue { get; set; }
        public string? LongName { get; set; }
        public string? ShortName { get; set; }
    }
}
