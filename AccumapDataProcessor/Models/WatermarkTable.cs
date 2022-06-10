using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class WatermarkTable
    {
        public string? WatermarkTableName { get; set; }
        public string? WatermarkColumn { get; set; }
        public string? WatermarkValue { get; set; }
        public DateTime? WatermarkDatetime { get; set; }
    }
}
