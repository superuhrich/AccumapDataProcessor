using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TQbyteInvoiceType
    {
        public DateTime? CreateDate { get; set; }
        public string? CreateUser { get; set; }
        public string? InvcTypeCode { get; set; }
        public string? PayableOrReceivableCode { get; set; }
        public string? CtrlMajorAcct { get; set; }
        public string? CtrlMinorAcct { get; set; }
        public string? InvcTypeDesc { get; set; }
        public string? PurchaseOrderReqdFlag { get; set; }
        public string? LastUpdtUser { get; set; }
        public DateTime? LastUpdtDate { get; set; }
        public decimal? CreditDays { get; set; }
        public string? CreditAnalyst { get; set; }
        public string? AutoCalcInvcGstFlag { get; set; }
        public string? CashCallFlag { get; set; }
    }
}
