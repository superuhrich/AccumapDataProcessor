using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TRunStatusCode
    {
        public int StatusCode { get; set; }
        public string Status { get; set; } = null!;
        public string? Description { get; set; }
    }
}
