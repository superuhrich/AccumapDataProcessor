using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class VRptServiceAgreementFeeContract
    {
        public string ServiceFileNumber { get; set; } = null!;
        public string? ServiceFileStatus { get; set; }
        public string? FacilityFileNumber { get; set; }
        public string? FacilityFileSub { get; set; }
        public string? FacilityFileStatus { get; set; }
        public DateTime? ContractDate { get; set; }
        public string? Producer { get; set; }
        public string? Processor { get; set; }
        public string? ContractName { get; set; }
        public string? Division { get; set; }
        public string? Area { get; set; }
        public string? AdminCompany { get; set; }
        public string? Location { get; set; }
        public string? ProjectNumber { get; set; }
        public string? ProjectDescription { get; set; }
        public string? ProcessorLocation { get; set; }
        public string? ProcessorProject { get; set; }
        public string? ProcDescription { get; set; }
        public string? ServiceType { get; set; }
        public string VariableFee { get; set; } = null!;
        public decimal? CapitalFee { get; set; }
        public decimal? OperatingFee { get; set; }
        public decimal? TotalFees { get; set; }
        public string? FeeBasis { get; set; }
        public DateTime? FeeEffectiveDate { get; set; }
        public DateTime? TerminationDate { get; set; }
        public DateTime? ServiceTermDate { get; set; }
    }
}
