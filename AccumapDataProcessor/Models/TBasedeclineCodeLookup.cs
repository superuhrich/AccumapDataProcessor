using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TBasedeclineCodeLookup
    {
        public string CodeType { get; set; } = null!;
        public int CodeValue { get; set; }
        public string? LongName { get; set; }
        public string? ShortName { get; set; }
    }
}
