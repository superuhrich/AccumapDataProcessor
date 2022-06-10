using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TIhsBusinessAssociate
    {
        public string? BusinessAssociate { get; set; }
        public string? ActiveInd { get; set; }
        public string? BaAbbreviation { get; set; }
        public string? BaCategory { get; set; }
        public string? BaCode { get; set; }
        public string? BaName { get; set; }
        public string? BaShortName { get; set; }
        public string? BaType { get; set; }
        public DateTime? CreditCheckDate { get; set; }
        public string? CreditCheckInd { get; set; }
        public string? CreditCheckSource { get; set; }
        public string? CreditRating { get; set; }
        public string? CreditRatingSource { get; set; }
        public string? CurrentStatus { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? MainEmailAddress { get; set; }
        public string? MainFaxNum { get; set; }
        public string? MainPhoneNum { get; set; }
        public string? MainWebUrl { get; set; }
        public string? MiddleInitial { get; set; }
        public string? PpdmGuid { get; set; }
        public string? Remark { get; set; }
        public string? Source { get; set; }
        public string? RowChangedBy { get; set; }
        public DateTime? RowChangedDate { get; set; }
        public string? RowCreatedBy { get; set; }
        public DateTime? RowCreatedDate { get; set; }
        public string? RowQuality { get; set; }
        public string? BaGroup { get; set; }
    }
}
