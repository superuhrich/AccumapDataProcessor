using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class FcExpenseIncomeReport
    {
        public decimal? SysId { get; set; }
        public string? CreateUser { get; set; }
        public DateTime? CreateDateTime { get; set; }
        public decimal? ProductionDate { get; set; }
        public decimal? JobId { get; set; }
        public string? ReportTitle { get; set; }
        public string? OwnerId { get; set; }
        public string? FacilityType { get; set; }
        public string? FacilityId { get; set; }
        public string? BatteryId { get; set; }
        public string? ExpenseFacilityType { get; set; }
        public string? ExpenseFacilityId { get; set; }
        public string? ProductCode { get; set; }
        public string? ChargeType { get; set; }
        public string? ChargeDescription { get; set; }
        public string? PrimaryRetrieval { get; set; }
        public string? PrimaryRetrievalDescription { get; set; }
        public decimal? ChargeSequenceNumber { get; set; }
        public string? CostCentreId { get; set; }
        public decimal? RevisedVolume { get; set; }
        public decimal? PreviousVolume { get; set; }
        public decimal? NetVolume { get; set; }
        public decimal? RevisedValue { get; set; }
        public decimal? PreviousValue { get; set; }
        public decimal? NetValue { get; set; }
        public decimal? AccountingDate { get; set; }
        public decimal? RevisedGstValue { get; set; }
        public decimal? RevisedPstValue { get; set; }
        public decimal? PreviousGstValue { get; set; }
        public decimal? PreviousPstValue { get; set; }
        public decimal? NetGstValue { get; set; }
        public decimal? NetPstValue { get; set; }
    }
}
