using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TProdviewAllocatedVolumesIncr
    {
        public string? Idflownet { get; set; }
        public string? Keymigrationsource { get; set; }
        public string? Compida { get; set; }
        public string? CcNum { get; set; }
        public string? Completionname { get; set; }
        public string? Name { get; set; }
        public string? Nameshort { get; set; }
        public string? Facilityidd { get; set; }
        public string? Typmigrationsource { get; set; }
        public DateTime? Dttm { get; set; }
        public decimal? HoursOn { get; set; }
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
        public double? Prestub { get; set; }
        public double? Prescas { get; set; }
    }
}
