using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TIhsPdenVolByMonthIncr1
    {
        public string PdenId { get; set; } = null!;
        public string PdenType { get; set; } = null!;
        public string PdenSource { get; set; } = null!;
        public string VolumeMethod { get; set; } = null!;
        public string ActivityType { get; set; } = null!;
        public string ProductType { get; set; } = null!;
        public decimal Year { get; set; }
        public decimal AmendmentSeqNo { get; set; }
        public string? ActiveInd { get; set; }
        public string? AmendReason { get; set; }
        public decimal? AprVolume { get; set; }
        public decimal? AprVolumeQual { get; set; }
        public decimal? AugVolume { get; set; }
        public decimal? AugVolumeQual { get; set; }
        public decimal? CumVolume { get; set; }
        public decimal? DecVolume { get; set; }
        public decimal? DecVolumeQual { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public decimal? FebVolume { get; set; }
        public decimal? FebVolumeQual { get; set; }
        public decimal? JanVolume { get; set; }
        public decimal? JanVolumeQual { get; set; }
        public decimal? JulVolume { get; set; }
        public decimal? JulVolumeQual { get; set; }
        public decimal? JunVolume { get; set; }
        public decimal? JunVolumeQual { get; set; }
        public decimal? MarVolume { get; set; }
        public decimal? MarVolumeQual { get; set; }
        public decimal? MayVolume { get; set; }
        public decimal? MayVolumeQual { get; set; }
        public decimal? NovVolume { get; set; }
        public decimal? NovVolumeQual { get; set; }
        public decimal? OctVolume { get; set; }
        public decimal? OctVolumeQual { get; set; }
        public DateTime? PostedDate { get; set; }
        public string? PpdmGuid { get; set; }
        public string? Remark { get; set; }
        public decimal? SepVolume { get; set; }
        public decimal? SepVolumeQual { get; set; }
        public DateTime? VolumeEndDate { get; set; }
        public string? VolumeOuom { get; set; }
        public string? VolumeQualityOuom { get; set; }
        public DateTime? VolumeStartDate { get; set; }
        public string? VolumeUom { get; set; }
        public decimal? YtdVolume { get; set; }
        public string? RowChangedBy { get; set; }
        public DateTime? RowChangedDate { get; set; }
        public string? RowCreatedBy { get; set; }
        public DateTime? RowCreatedDate { get; set; }
        public string? RowQuality { get; set; }
        public string ProvinceState { get; set; } = null!;
        public string? PoolId { get; set; }
        public string? XStratUnitId { get; set; }
        public decimal? TopStratAge { get; set; }
        public decimal? BaseStratAge { get; set; }
        public string? StratNameSetId { get; set; }
    }
}
