using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class VFactSourceValnavReservesBudgetRi
    {
        public string? EntityId { get; set; }
        public string? FormattedId { get; set; }
        public string? Uwi { get; set; }
        public string? ReserveCategoryId { get; set; }
        public string Accounts { get; set; } = null!;
        public string ScenarioType { get; set; } = null!;
        public string? Scenario { get; set; }
        public DateTime? BookedDate { get; set; }
        public double? RiVolumeImp { get; set; }
        public double? RiVolumeMet { get; set; }
        public double? RiVolumeBoe { get; set; }
        public double? RiVolumeMcfe { get; set; }
    }
}
