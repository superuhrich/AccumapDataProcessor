using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class BaTable
    {
        public string PrimaryKey { get; set; } = null!;
        public string FileStatus { get; set; } = null!;
        public string AlternateCode { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? AddressLine1 { get; set; }
        public string? AddressLine2 { get; set; }
        public string? AddressLine3 { get; set; }
        public string? AddressLine4 { get; set; }
        public string? AddressLine5 { get; set; }
        public string ShortName { get; set; } = null!;
        public string? ContactName { get; set; }
        public string? PhoneNumber { get; set; }
        public string? EMailAddress { get; set; }
        public string? FaxNumber { get; set; }
        public string? MailFlags { get; set; }
        public string? SinNumber { get; set; }
        public string? CombineRental { get; set; }
        public decimal? MinChequeAmount { get; set; }
        public decimal? BankFee { get; set; }
        public string? CurrencyCountry { get; set; }
        public string? WtaxCountry { get; set; }
        public string? GstRegNo { get; set; }
        public string? SapCode { get; set; }
    }
}
