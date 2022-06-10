using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TApUser
    {
        public int Id { get; set; }
        public string? ApUser { get; set; }
        public string? VendorStartLetter { get; set; }
        public string? VendorEndLetter { get; set; }
    }
}
