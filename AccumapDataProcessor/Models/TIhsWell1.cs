﻿using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TIhsWell1
    {
        public string Uwi { get; set; } = null!;
        public DateTime? AbandonmentDate { get; set; }
        public string? ActiveInd { get; set; }
        public string? AssignedField { get; set; }
        public string? BaseNodeId { get; set; }
        public decimal? BottomHoleLatitude { get; set; }
        public decimal? BottomHoleLongitude { get; set; }
        public decimal? CasingFlangeElev { get; set; }
        public string? CasingFlangeElevOuom { get; set; }
        public DateTime? CompletionDate { get; set; }
        public DateTime? ConfidentialDate { get; set; }
        public decimal? ConfidentialDepth { get; set; }
        public string? ConfidentialDepthOuom { get; set; }
        public string? ConfidentialType { get; set; }
        public string? ConfidStratNameSetId { get; set; }
        public string? ConfidStratUnitId { get; set; }
        public string? Country { get; set; }
        public string? County { get; set; }
        public string? CurrentClass { get; set; }
        public string? CurrentStatus { get; set; }
        public DateTime? CurrentStatusDate { get; set; }
        public decimal? DeepestDepth { get; set; }
        public string? DeepestDepthOuom { get; set; }
        public string? DepthDatum { get; set; }
        public decimal? DepthDatumElev { get; set; }
        public string? DepthDatumElevOuom { get; set; }
        public decimal? DerrickFloorElev { get; set; }
        public string? DerrickFloorElevOuom { get; set; }
        public decimal? DifferenceLatMsl { get; set; }
        public string? DiscoveryInd { get; set; }
        public string? District { get; set; }
        public decimal? DrillTd { get; set; }
        public string? DrillTdOuom { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public string? ElevRefDatum { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public string? FaultedInd { get; set; }
        public DateTime? FinalDrillDate { get; set; }
        public decimal? FinalTd { get; set; }
        public string? FinalTdOuom { get; set; }
        public string? GeographicRegion { get; set; }
        public string? GeologicProvince { get; set; }
        public decimal? GroundElev { get; set; }
        public string? GroundElevOuom { get; set; }
        public string? GroundElevType { get; set; }
        public string? InitialClass { get; set; }
        public decimal? KbElev { get; set; }
        public string? KbElevOuom { get; set; }
        public string? LeaseName { get; set; }
        public string? LeaseNum { get; set; }
        public string? LegalSurveyType { get; set; }
        public string? LocationType { get; set; }
        public decimal? LogTd { get; set; }
        public string? LogTdOuom { get; set; }
        public decimal? MaxTvd { get; set; }
        public string? MaxTvdOuom { get; set; }
        public decimal? NetPay { get; set; }
        public string? NetPayOuom { get; set; }
        public decimal? OldestStratAge { get; set; }
        public string? OldestStratNameSetAge { get; set; }
        public string? OldestStratNameSetId { get; set; }
        public string? OldestStratUnitId { get; set; }
        public string? Operator { get; set; }
        public string? ParentRelationshipType { get; set; }
        public string? ParentUwi { get; set; }
        public string? PlatformId { get; set; }
        public string? PlatformSfType { get; set; }
        public string? PlotName { get; set; }
        public string? PlotSymbol { get; set; }
        public decimal? PlugbackDepth { get; set; }
        public string? PlugbackDepthOuom { get; set; }
        public string? PpdmGuid { get; set; }
        public string? PrimarySource { get; set; }
        public string? ProfileType { get; set; }
        public string ProvinceState { get; set; } = null!;
        public string? RegulatoryAgency { get; set; }
        public string? Remark { get; set; }
        public DateTime? RigOnSiteDate { get; set; }
        public DateTime? RigReleaseDate { get; set; }
        public decimal? RotaryTableElev { get; set; }
        public string? SourceDocument { get; set; }
        public DateTime? SpudDate { get; set; }
        public string? StatusType { get; set; }
        public string? SubseaElevRefType { get; set; }
        public decimal? SurfaceLatitude { get; set; }
        public decimal? SurfaceLongitude { get; set; }
        public string? SurfaceNodeId { get; set; }
        public string? TaxCreditCode { get; set; }
        public decimal? TdStratAge { get; set; }
        public string? TdStratNameSetAge { get; set; }
        public string? TdStratNameSetId { get; set; }
        public string? TdStratUnitId { get; set; }
        public decimal? WaterAcousticVel { get; set; }
        public string? WaterAcousticVelOuom { get; set; }
        public decimal? WaterDepth { get; set; }
        public string? WaterDepthDatum { get; set; }
        public string? WaterDepthOuom { get; set; }
        public string? WellEventNum { get; set; }
        public string? WellGovernmentId { get; set; }
        public decimal? WellIntersectMd { get; set; }
        public string? WellName { get; set; }
        public string? WellNum { get; set; }
        public decimal? WellNumericId { get; set; }
        public decimal? WhipstockDepth { get; set; }
        public string? WhipstockDepthOuom { get; set; }
        public string? RowChangedBy { get; set; }
        public DateTime? RowChangedDate { get; set; }
        public string? RowCreatedBy { get; set; }
        public DateTime? RowCreatedDate { get; set; }
        public string? RowQuality { get; set; }
        public string? XCurrentLicensee { get; set; }
        public decimal? XEventNum { get; set; }
        public decimal? XEventNumMax { get; set; }
        public string? XOffshoreInd { get; set; }
        public DateTime? XOnprodDate { get; set; }
        public DateTime? XOninjectDate { get; set; }
        public string? XPool { get; set; }
        public string? XUwiSort { get; set; }
        public string? XUwiDisplay { get; set; }
        public decimal? XTdTvd { get; set; }
        public decimal? XPlugbackTvd { get; set; }
        public decimal? XWhipstockTvd { get; set; }
        public string? XOriginalStatus { get; set; }
        public string? XOriginalUnit { get; set; }
        public string? XPreviousStatus { get; set; }
        public decimal? ConfidStratAge { get; set; }
        public string? XSurfaceAbandonType { get; set; }
        public string? GeogCoordSystemId { get; set; }
        public string? LocationQualifier { get; set; }
        public string? XConfidentialPeriod { get; set; }
        public string? XPrimaryBoreholeUwi { get; set; }
        public string? XDigitalLogInd { get; set; }
        public string? XRasterLogInd { get; set; }
        public decimal? XLateralLength { get; set; }
    }
}
