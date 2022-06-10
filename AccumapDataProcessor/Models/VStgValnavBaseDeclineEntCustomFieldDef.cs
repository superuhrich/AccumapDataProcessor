using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class VStgValnavBaseDeclineEntCustomFieldDef
    {
        public string ParentId { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? StringValue { get; set; }
        public DateTime? DateValue { get; set; }
        public double? NumericValue { get; set; }
    }
}
