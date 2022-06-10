using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class VRptOpenticketsCurrentStatus
    {
        public string? Username { get; set; }
        public string? SupplierName { get; set; }
        public string? TicketStatus { get; set; }
        public int? NumberOfTickets { get; set; }
    }
}
