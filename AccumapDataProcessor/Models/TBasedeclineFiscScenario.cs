using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TBasedeclineFiscScenario
    {
        public string ObjectId { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public int ScenarioType { get; set; }
        public long LastChangeDate { get; set; }
        public string? OwnedBy { get; set; }
        public byte? OverridePlanParameters { get; set; }
    }
}
