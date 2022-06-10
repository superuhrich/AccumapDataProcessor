using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TStgPortfolioPricingText
    {
        public string? StripDate { get; set; }
        public string? Comment { get; set; }
        public string? ProductType { get; set; }
        public string? Name { get; set; }
        public string? SettlementPeriod { get; set; }
        public string? Units { get; set; }
        public string? Currency { get; set; }
        public string? DeliveryDate { get; set; }
        public string? StripPrice { get; set; }
        public string? ManualOverride { get; set; }
        public string? RealizedPrice { get; set; }
        public string? PortfolioPrice { get; set; }
    }
}
