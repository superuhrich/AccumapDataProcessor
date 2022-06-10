using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class MarketMasterPurchPrice
    {
        public string CreateUser { get; set; } = null!;
        public string? CreateProgram { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string LastUpdateUser { get; set; } = null!;
        public string? LastUpdateProgram { get; set; }
        public DateTime LastUpdateDateTime { get; set; }
        public decimal? LastUpdateAuditId { get; set; }
        public decimal Version { get; set; }
        public decimal SysId { get; set; }
        public decimal ProductionDate { get; set; }
        public string? PriceCode { get; set; }
        public decimal? InputPrice { get; set; }
        public decimal? InputSalesValue { get; set; }
        public decimal? TransportationCost { get; set; }
        public string? TransportationCostType { get; set; }
        public string? TransportsGas { get; set; }
        public decimal? LineLoss { get; set; }
        public string? LineLossType { get; set; }
        public decimal MarketMasterPurchaserSysId { get; set; }
        public string? UserDefined1 { get; set; }
    }
}
