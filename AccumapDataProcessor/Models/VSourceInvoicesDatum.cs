using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class VSourceInvoicesDatum
    {
        public string? InvoiceKey { get; set; }
        public string? InvoiceNumber { get; set; }
        public string? VendorCode { get; set; }
        public string? InvoiceDate { get; set; }
        public double? InvoiceTotal { get; set; }
        public string? SiteName { get; set; }
        public string? DepartmentName { get; set; }
        public string? UserName { get; set; }
        public DateTime TodaysDate { get; set; }
        public int? ElapsedDays { get; set; }
        public int? LessThan30Days { get; set; }
        public int? _3060Days { get; set; }
        public int? _6090Days { get; set; }
        public int? Over90Days { get; set; }
        public string? VendorName { get; set; }
        public string ExcludeQbyte { get; set; } = null!;
        public string IncludeQbyte { get; set; } = null!;
    }
}
