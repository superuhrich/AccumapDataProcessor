using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TStgAvocetMvFvSite
    {
        public string SiteId { get; set; } = null!;
        public string? DistrictId { get; set; }
        public string? ProvinceId { get; set; }
        public string? CountryId { get; set; }
        public string? FieldId { get; set; }
        public decimal? CorporateParentId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string? Name { get; set; }
        public string? ShortName { get; set; }
        public string? Notes { get; set; }
        public string? Location { get; set; }
        public string? SecondaryLocation { get; set; }
        public string? PaCode { get; set; }
        public string? SecondaryPaCode { get; set; }
        public decimal? Status { get; set; }
        public double? Latitude { get; set; }
        public double? Elevation { get; set; }
        public decimal? Type { get; set; }
        public decimal? NonOperated { get; set; }
        public double? Longitude { get; set; }
        public string? GasStreamId { get; set; }
        public string? Subsection { get; set; }
        public string? Section { get; set; }
        public string? Township { get; set; }
        public string? Range { get; set; }
        public string? FormattedSecondaryLocation { get; set; }
        public string? FormattedLocation { get; set; }
        public string? TagId { get; set; }
        public string? OwnerGuid { get; set; }
        public double? Datapoint1 { get; set; }
        public double? Datapoint2 { get; set; }
        public double? Datapoint3 { get; set; }
        public double? Datapoint4 { get; set; }
        public double? Datapoint5 { get; set; }
        public string? Datapoint6 { get; set; }
        public string? Datapoint7 { get; set; }
        public string? Datapoint8 { get; set; }
        public string? Datapoint9 { get; set; }
        public string? Datapoint10 { get; set; }
        public decimal? ChangeCounter { get; set; }
    }
}
