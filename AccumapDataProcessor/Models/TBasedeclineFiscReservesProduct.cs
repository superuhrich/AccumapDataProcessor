using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TBasedeclineFiscReservesProduct
    {
        public string ObjectId { get; set; } = null!;
        public string ShortName { get; set; } = null!;
        public string LongName { get; set; } = null!;
        public string QueryNameFragment { get; set; } = null!;
        public string AssociatedProduct { get; set; } = null!;
        public byte IncludeInRecon { get; set; }
        public int SortOrder { get; set; }
    }
}
