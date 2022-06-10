using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TStgFieldticket
    {
        public string? ItemId { get; set; }
        public string? TicketNumber { get; set; }
        public string? TicketType { get; set; }
        public string? TicketStatus { get; set; }
        public string? SupplierName { get; set; }
        public string? SupplierSitename { get; set; }
        public string? SupplierNumber { get; set; }
        public string? BuyerName { get; set; }
        public string? BuyerDuns { get; set; }
        public string? ApproverName { get; set; }
        public string? TotalAmount { get; set; }
        public string? CurrencyCode { get; set; }
        public string? Description { get; set; }
        public string? OrderedbyUserid { get; set; }
        public string? OrderedbyUsername { get; set; }
        public string? Driver { get; set; }
        public string? TruckNumber { get; set; }
        public string? InvoicedStatus { get; set; }
        public string? ReferencingInvoiceNumber { get; set; }
        public string? LastActionDatetime { get; set; }
        public string? LineitemProductServiceCode { get; set; }
        public string? LineitemProductServiceId { get; set; }
        public string? LineitemDescription { get; set; }
        public string? LineitemNumber { get; set; }
        public string? LineitemPayload { get; set; }
        public string? CostCentre { get; set; }
        public string? ServiceDate { get; set; }
        public string? Major { get; set; }
        public string? MajorDescription { get; set; }
        public string? Minor { get; set; }
        public string? MinorDescription { get; set; }
        public string? CadDollars { get; set; }
        public string? M3Volumes { get; set; }
    }
}
