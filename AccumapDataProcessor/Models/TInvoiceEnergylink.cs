using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TInvoiceEnergylink
    {
        public string? InvoiceKey { get; set; }
        public string? OrgId { get; set; }
        public string? MajorAccount { get; set; }
        public string? MinorAccount { get; set; }
        public string? AfeNumber { get; set; }
        public string? CostCentre { get; set; }
        public string? ServiceDate { get; set; }
        public double? Amount { get; set; }
    }
}
