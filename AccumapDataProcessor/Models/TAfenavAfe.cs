using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TAfenavAfe
    {
        public string? DocumentId { get; set; }
        public int? Version { get; set; }
        public string? FieldcostDoc { get; set; }
        public string? ActualDoc { get; set; }
        public string? AccrualDoc { get; set; }
        public string? AfenumberDoc { get; set; }
        public DateTime? Completed { get; set; }
        public string? InternalJustification { get; set; }
        public string? ExternalJustification { get; set; }
        public string? Description { get; set; }
        public DateTime? StartDate { get; set; }
        public string? ChainGuid { get; set; }
        public DateTime? EndDate { get; set; }
        public int? BudgetYear { get; set; }
        public string? CurrencyCode { get; set; }
        public DateTime? EstimateConversionDate { get; set; }
        public string? OutsideAfenumber { get; set; }
        public byte? OpNotice { get; set; }
        public DateTime? RequiredByDate { get; set; }
        public string? VersionString { get; set; }
        public string? BudgetManager { get; set; }
        public string? Owner { get; set; }
        public string? Creator { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? BaseCreationDate { get; set; }
        public byte? Closed { get; set; }
        public string? ClosedUser { get; set; }
        public DateTime? ClosedDate { get; set; }
        public string? ClosedReason { get; set; }
        public string? SilentPartnerMode { get; set; }
        public string? WellListTitle { get; set; }
        public string? WellReportingIdentifier { get; set; }
        public decimal? TotalGrossEstimate { get; set; }
        public string? Status { get; set; }
        public string? StatusDesc { get; set; }
        public decimal? TotalNetEstimate { get; set; }
        public decimal? OurWi { get; set; }
        public string? ParentCompany { get; set; }
        public string? OperatingCompany { get; set; }
        public byte? Fasttrack { get; set; }
        public string? SupersededStatus { get; set; }
        public string? SupersededStatusDesc { get; set; }
        public decimal? ApprovedGrossEstimate { get; set; }
        public decimal? ApprovedNetEstimate { get; set; }
        public decimal? SupplementalGrossEstimate { get; set; }
        public decimal? SupplementalNetEstimate { get; set; }
        public string? ParentRtd { get; set; }
        public string? VnCostType { get; set; }
        public string? VnEntity { get; set; }
        public string? VnPlan { get; set; }
        public string? VnScenario { get; set; }
        public string? VnRescat { get; set; }
        public string? ReleaseComment { get; set; }
        public DateTime? ReleasedDate { get; set; }
        public string? ReleaseUser { get; set; }
        public string? RoutedComment { get; set; }
        public DateTime? RoutedDate { get; set; }
        public string? RoutedUser { get; set; }
        public DateTime? InternalApprovalDate { get; set; }
        public DateTime? FullApprovalDate { get; set; }
        public DateTime? ReviewCompletedDate { get; set; }
        public string? AfelinkTrackingId { get; set; }
        public int? LegacyAfeid { get; set; }
        public int? LegacyChainid { get; set; }
        public int? ChainVersion { get; set; }
        public string? RevSupMode { get; set; }
        public int? RevNumber { get; set; }
        public int? SupNumber { get; set; }
        public int? CorrNumber { get; set; }
        public DateTime? SupersededDate { get; set; }
        public string? NextApprovingPositions { get; set; }
        public string? NextReviewingPositions { get; set; }
        public int? Afeid { get; set; }
        public int? Afechainid { get; set; }
        public int? Afeoperatingpartner { get; set; }
        public byte? Afecashcall { get; set; }
        public DateTime? Afereleasedate { get; set; }
        public int? Revision { get; set; }
        public DateTime? Afesupersededdate { get; set; }
        public byte? Hasexternalapproval { get; set; }
        public byte? Isrevised { get; set; }
        public byte? Issupplemented { get; set; }
        public int? Aferevnumber { get; set; }
        public int? Afesupnumber { get; set; }
        public int? Afecorrnumber { get; set; }
        public int? LastUpdateUser { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public int? NextPosition { get; set; }
        public DateTime? RouteForReviewDate { get; set; }
        public string? CopyOfAfeGuid { get; set; }
        public string? CopyOfAfestatus { get; set; }
        public string? CopyOfAferevsupmode { get; set; }
        public string? CopyOfExternalId { get; set; }
        public string? CopyOfNextReviewingPosition { get; set; }
        public string? CopyOfSupersededAfestatus { get; set; }
        public string? CopyOfNextApprovingPositions { get; set; }
        public string? CopyOfAfeDoc { get; set; }
    }
}
