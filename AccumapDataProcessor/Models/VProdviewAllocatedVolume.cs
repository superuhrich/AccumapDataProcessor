using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class VProdviewAllocatedVolume
    {
        public string Idflownet { get; set; } = null!;
        public string? Keymigrationsource { get; set; }
        public string? Compida { get; set; }
        public string? CcNum { get; set; }
        public string? Completionname { get; set; }
        public string? Name { get; set; }
        public string? Nameshort { get; set; }
        public string? Facilityidd { get; set; }
        public string? Typmigrationsource { get; set; }
        public string? Unitidc { get; set; }
        public DateTime? Dttm { get; set; }
        public double? HoursOn { get; set; }
        public double? Gassalesestimate { get; set; }
        public double? Voldispsalehcliq { get; set; }
        public double? Voldispinjectwater { get; set; }
        public double? Volprodallochcliq { get; set; }
        public double? Volprodgathgas { get; set; }
        public double? Volprodgathhcliq { get; set; }
        public double? Volprodgathwater { get; set; }
        public double? Volnewprodallochcliq { get; set; }
        public double? Volnewprodallocwater { get; set; }
        public double? Volremainrecovhcliq { get; set; }
        public double? Prescas { get; set; }
        public double? Prestub { get; set; }
    }
}
