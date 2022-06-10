﻿using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class StageDetailLineItemsArarConvertedPy
    {
        public string? Key { get; set; }
        public DateTime? Timestamp { get; set; }
        public string LineItemName { get; set; } = null!;
        public DateTime ProdMonth { get; set; }
        public DateTime? AcctMonth { get; set; }
        public int? BapurchaserId { get; set; }
        public string Baname { get; set; } = null!;
        public string? OriginLocation { get; set; }
        public string Product { get; set; } = null!;
        public string? DeliveryLocation { get; set; }
        public string? FacilityCode { get; set; }
        public string? ProductionAccountant { get; set; }
        public string? LineItemMasterFk { get; set; }
        public int? LimAutoCount { get; set; }
        public double? Volume { get; set; }
        public double? Dollars { get; set; }
        public double? Energy { get; set; }
        public string? Comment { get; set; }
        public bool? Amendment { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool? Hide { get; set; }
    }
}
