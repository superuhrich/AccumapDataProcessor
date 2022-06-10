using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class VProdviewDowntimeHoursVolumesIncr
    {
        public string Idflownet { get; set; } = null!;
        public string? Keymigrationsource { get; set; }
        public string? Compida { get; set; }
        public string? CcNum { get; set; }
        public string? Completionname { get; set; }
        public string? Name { get; set; }
        public string? Nameshort { get; set; }
        public string? Typmigrationsource { get; set; }
        public DateTime? Dttm { get; set; }
        public double? HoursOn { get; set; }
        public double? HoursDown { get; set; }
        public double? Vollosthcliq { get; set; }
        public double? Vollostgas { get; set; }
        public double? Vollostwater { get; set; }
        public double? Durdown { get; set; }
        public double? Durop { get; set; }
        public string? Codedowntm1 { get; set; }
    }
}
