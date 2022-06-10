using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TReservesCustomFieldDef
    {
        public string ObjectId { get; set; } = null!;
        public string Name { get; set; } = null!;
        public int UsageType { get; set; }
        public int DefType { get; set; }
        public byte SecurityEnabled { get; set; }
        public string? Format { get; set; }
        public int? Precision { get; set; }
        public string? ImperialUnit { get; set; }
        public string? MetricUnit { get; set; }
        public byte? EnforceValues { get; set; }
        public string? DefaultListValue { get; set; }
    }
}
