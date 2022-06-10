using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TAfenavLutAfeType
    {
        public string DocumentId { get; set; } = null!;
        public int Version { get; set; }
        public byte Active { get; set; }
        public int CodeNum { get; set; }
        public string? OtherValue1 { get; set; }
        public string? OtherValue2 { get; set; }
        public string? Value { get; set; }
    }
}
