using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TAfenavAfenumber
    {
        public string DocumentId { get; set; } = null!;
        public int Version { get; set; }
        public string? Afenumber { get; set; }
    }
}
