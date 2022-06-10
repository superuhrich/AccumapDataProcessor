using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TInvoiceLineItemsIncr20220527
    {
        public string? InvoiceKey { get; set; }
        public string? LineItemNumber { get; set; }
        public string? RateOrPercentage { get; set; }
        public string? Quantity { get; set; }
        public string? Description { get; set; }
        public string? ServiceDate { get; set; }
        public string? MajorAccount { get; set; }
        public string? MinorAccount { get; set; }
        public string? AccountType { get; set; }
        public string? AccountDescription { get; set; }
        public string? TaxType { get; set; }
        public double? Amount { get; set; }
        public string? AfeNumber { get; set; }
        public string? CostCentre { get; set; }
        public string? DocumentType { get; set; }
        public string? DocumentNumber { get; set; }
    }
}
