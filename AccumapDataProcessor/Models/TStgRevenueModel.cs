using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TStgRevenueModel
    {
        public int Id { get; set; }
        public string? DeliveryDate { get; set; }
        public string? PropertyCommonName { get; set; }
        public string? SubProduct { get; set; }
        public double? PurchaserId { get; set; }
        public string? SpecOrMix { get; set; }
        public string? Penalty { get; set; }
        public string? ProducingLocation { get; set; }
        public string? SalesLocation { get; set; }
        public string? AccountingLineItemName { get; set; }
        public string? Amendment { get; set; }
        public string? ProducingLocationName { get; set; }
        public string? SalesLocationName { get; set; }
        public string? CodeName { get; set; }
        public string? ProductionSalesCode { get; set; }
        public string? PurchaserName { get; set; }
        public double? GrossPriceM3 { get; set; }
        public string? OffsetBaseTrucking { get; set; }
        public string? OffsetAncillaryTrucking { get; set; }
        public double? OffsetFractionation { get; set; }
        public double? OffsetTransportation { get; set; }
        public string? OffsetTariff { get; set; }
        public string? OffsetLossAllowance { get; set; }
        public string? OffsetOther { get; set; }
        public string? OffsetWadf { get; set; }
        public string? OffsetEnbridgeWadf { get; set; }
        public double? SalesVolumeM3Month { get; set; }
        public double? SettlementInputMonth { get; set; }
        public double? SettlementMonth { get; set; }
        public double? SettlementDeltaMonth { get; set; }
        public double? DeltaVsSettlement { get; set; }
        public double? NetPriceM3 { get; set; }
        public double? OpexTransportationRateM3 { get; set; }
        public double? OpexTransportationTakeOrPayRateM3 { get; set; }
        public double? OpexTransportationTakeOrPayMonth { get; set; }
        public double? OpexTransportationMonth { get; set; }
        public string? OpexBaseTruckingRateM3 { get; set; }
        public string? OpexAncillaryTruckingRateM3 { get; set; }
        public string? OpexBaseTruckingMonth { get; set; }
        public string? OpexAncillaryTruckingMonth { get; set; }
        public double? SettlementNetTruckingTranspotOpexMonth { get; set; }
        public double? NetbackPriceNetOfOpexM3 { get; set; }
        public string? ProducingMeterStationCode { get; set; }
        public DateTime? Timeofload { get; set; }
    }
}
