using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class FcFormulaRetrieval
    {
        public string CreateUser { get; set; } = null!;
        public DateTime CreateDateTime { get; set; }
        public string LastUpdateUser { get; set; } = null!;
        public DateTime LastUpdateDateTime { get; set; }
        public decimal Version { get; set; }
        public string ActiveValue { get; set; } = null!;
        public string Code { get; set; } = null!;
        public string CalculationBasedFlag { get; set; } = null!;
        public string EntityExceptionsFlag { get; set; } = null!;
        public string FromToExceptionsFlag { get; set; } = null!;
        public string PurchaserExceptionsFlag { get; set; } = null!;
        public string UnitWellFlag { get; set; } = null!;
        public string UnitTractFlag { get; set; } = null!;
        public string Category { get; set; } = null!;
        public string BatteryUsage { get; set; } = null!;
        public string GgsUsage { get; set; } = null!;
        public string PlantUsage { get; set; } = null!;
        public string UnitUsage { get; set; } = null!;
        public string OilUsage { get; set; } = null!;
        public string WaterUsage { get; set; } = null!;
        public string NaUsage { get; set; } = null!;
        public string GasUsage { get; set; } = null!;
        public string BypUsage { get; set; } = null!;
        public string? CreateProgram { get; set; }
        public string? LastUpdateProgram { get; set; }
        public decimal? LastUpdateAuditId { get; set; }
        public string? Description { get; set; }
        public string? ShortDescription { get; set; }
        public decimal? SortOrder { get; set; }
        public string? UsageDetails { get; set; }
    }
}
