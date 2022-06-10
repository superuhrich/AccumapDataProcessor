using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TQbyteBaAddress
    {
        public DateTime? CreateDate { get; set; }
        public string? CreateUser { get; set; }
        public decimal? Id { get; set; }
        public decimal? BaId { get; set; }
        public string? AddressTypeCode { get; set; }
        public string? ShortName { get; set; }
        public string? AddressLine1 { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public string? LastUpdateUser { get; set; }
        public decimal? ChangedToBaAddressId { get; set; }
        public string? Phone { get; set; }
        public string? PhoneExtension { get; set; }
        public string? Fax { get; set; }
        public string? Fax2 { get; set; }
        public string? Email { get; set; }
        public string? City { get; set; }
        public string? PostalCode { get; set; }
        public string? ProvinceCode { get; set; }
        public string? CountryCode { get; set; }
        public string? AlternateBaName1 { get; set; }
        public string? AlternateBaName2 { get; set; }
        public string? AddressLine2 { get; set; }
        public string? AddressLine3 { get; set; }
        public string? AddressLine4 { get; set; }
        public string? ExternalLinkRef { get; set; }
        public string? ExternalBaRef { get; set; }
        public string? ExternalBaAddressRef { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public DateTime? InactiveDate { get; set; }
        public string? InactivatedUser { get; set; }
    }
}
