using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class VEwfProdDatum
    {
        public string? Wellbore { get; set; }
        public DateTime? ProdDate { get; set; }
        public double? GasE3m3Volume { get; set; }
        public double? LiquidsM3Volume { get; set; }
        public long? RowId { get; set; }
    }
}
