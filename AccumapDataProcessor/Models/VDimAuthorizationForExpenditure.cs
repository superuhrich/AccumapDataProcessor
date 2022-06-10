﻿using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class VDimAuthorizationForExpenditure
    {
        public string AfeKey { get; set; } = null!;
        public string AfeNum { get; set; } = null!;
        public string? AfeName { get; set; }
        public string? AfeNameAttribute { get; set; }
        public string? ClientId { get; set; }
        public string? ClientName { get; set; }
        public string? OpNonop { get; set; }
        public string? RefOrgId { get; set; }
        public string? AfeTypeCode { get; set; }
        public string? AfeTypeDescription { get; set; }
        public string? AfeStatusCode { get; set; }
        public string? AfeStatusDescription { get; set; }
        public string? CostCentre { get; set; }
        public string? CostCentreName { get; set; }
        public string? CorpCode { get; set; }
        public string CorpName { get; set; } = null!;
        public string? Region { get; set; }
        public string? RegionCode { get; set; }
        public string? RegionName { get; set; }
        public string? District { get; set; }
        public string? DistrictCode { get; set; }
        public string? DistrictName { get; set; }
        public string? Area { get; set; }
        public string? AreaCode { get; set; }
        public string? AreaName { get; set; }
        public string? Facility { get; set; }
        public string? FacilityCode { get; set; }
        public string? FacilityName { get; set; }
        public string? CurrCode { get; set; }
        public decimal? OwnershipOrgId { get; set; }
        public string? JibFlag { get; set; }
        public string? CipTransferFlag { get; set; }
        public string? UseJibeEditsFlag { get; set; }
        public string? AccrualFlag { get; set; }
        public string? CreateDate { get; set; }
        public string? CreateUser { get; set; }
        public string? LastUpdtDate { get; set; }
        public string? LastUpdtUser { get; set; }
        public string? TermDate { get; set; }
        public string? TermUser { get; set; }
        public string? EffectiveDate { get; set; }
        public string? ProposalDate { get; set; }
        public string? DueDate { get; set; }
        public string? CommitmentDate { get; set; }
        public string? AfeApprovalDate { get; set; }
        public string? AfeStartDate { get; set; }
        public string? BudgetActivityYear { get; set; }
        public string? BudgetActivityYearDesc { get; set; }
        public int? ExtrapolatedBudgetYear { get; set; }
        public string? ProjectApprovalStatus { get; set; }
        public string? ProjectExecutionStatus { get; set; }
        public string? AfeDate { get; set; }
        public int? AcctYr { get; set; }
        public decimal? AllocAmt { get; set; }
        public string? TaxCode { get; set; }
        public string? CapitalAccrualMethodCode { get; set; }
        public string? ManagingOrgId { get; set; }
        public decimal NetEstimatePct { get; set; }
        public string? InternalApprover { get; set; }
        public string? ManagerName { get; set; }
        public string? SuccessEffortTypeCode { get; set; }
        public string? CapitalAccrualCcNum { get; set; }
        public decimal? EquipComponentAmt { get; set; }
        public decimal? WrhseComponentAmt { get; set; }
        public decimal? TranslationRate { get; set; }
        public decimal? OriginalAllocAmt { get; set; }
        public decimal? ReportingAllocAmt { get; set; }
        public string? AllowOtherOrgsCode { get; set; }
        public string? Province { get; set; }
        public string? EngineerAssigned { get; set; }
        public string? GeologistAssigned { get; set; }
        public string? GeophysicistAssigned { get; set; }
        public string? LastUpdtStatusUser { get; set; }
        public string? LastUpdtStatusDate { get; set; }
        public string? DoiTypeCode { get; set; }
        public string? AfeClassCode { get; set; }
        public string? DefaultGlSubCode { get; set; }
        public string? OverheadStartDate { get; set; }
        public string? OverheadEndDate { get; set; }
        public string? CapitalOrDryHoleExpCode { get; set; }
        public string? LastAccruedDate { get; set; }
        public string? CountryCode { get; set; }
        public string? SurveySystemCode { get; set; }
        public string? PrimaryUwi { get; set; }
        public string? UwiAlias { get; set; }
        public string? PrimaryLocation { get; set; }
        public string? SortedUwi { get; set; }
        public string? UwiSortElement1 { get; set; }
        public string? UwiSortElement2 { get; set; }
        public string? UwiSortElement3 { get; set; }
        public string? UwiSortElement4 { get; set; }
        public string? UwiSortElement5 { get; set; }
        public string? UwiSortElement6 { get; set; }
        public string? UwiSortElement7 { get; set; }
        public string? UwiSortElement8 { get; set; }
        public string? UwiSortElement9 { get; set; }
        public string? AfeUdf1Code { get; set; }
        public string? AfeUdf5Code { get; set; }
        public string? AfeUdf7Code { get; set; }
        public string? AfeUdf20Code { get; set; }
        public string? ProjectJustificationComments { get; set; }
        public string? AfeTypeGroup { get; set; }
        public string? AfeTypeGroupDesc { get; set; }
        public string? JobStartDate { get; set; }
        public string RigNumber { get; set; } = null!;
        public string RigName { get; set; } = null!;
        public string? ZonePlay { get; set; }
        public string? WellviewSpudDate { get; set; }
        public string? WellviewRigReleaseDate { get; set; }
        public double? WellviewTotalDepth { get; set; }
        public double? WellviewIntermediateCasingDepth { get; set; }
        public double? WellviewHorizontalDepth { get; set; }
        public string? AfeGcaFcc { get; set; }
        public string? CcList { get; set; }
        public int? NumberOfCcs { get; set; }
        public string? JobEndDate { get; set; }
    }
}
