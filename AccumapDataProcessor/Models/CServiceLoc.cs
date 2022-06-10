using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class CServiceLoc
    {
        public string FileNumber { get; set; } = null!;
        public decimal LocOccurrence { get; set; }
        public string? ProdWl { get; set; }
        public string? ProdWellNumber { get; set; }
        public string? ProdUwi { get; set; }
        public string? ProdSortedUwi { get; set; }
        public string? ProdDescription { get; set; }
        public string? ProdProject { get; set; }
        public string? ProdPriority { get; set; }
        public DateTime? ProdOffSrvDate { get; set; }
    }
}
