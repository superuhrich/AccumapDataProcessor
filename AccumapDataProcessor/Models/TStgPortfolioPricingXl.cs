using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TStgPortfolioPricingXl
    {
        public DateTime? StripDate { get; set; }
        public string? Comment { get; set; }
        public string? ProductType { get; set; }
        public string? Name { get; set; }
        public string? SettlementPeriod { get; set; }
        public string? Units { get; set; }
        public string? Currency { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public double? StripPrice { get; set; }
        public double? ManualOverride { get; set; }
        public double? RealizedPrice { get; set; }
        public double? PortfolioPrice { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
