using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TAfenavPartner
    {
        public string DocumentId { get; set; } = null!;
        public int Version { get; set; }
        public int Partnerid { get; set; }
        public string Comname { get; set; } = null!;
        public string? Code { get; set; }
        public string? Comnameshort { get; set; }
        public string? Contact { get; set; }
        public string? Straddress { get; set; }
        public string? City { get; set; }
        public string? ProvinceState { get; set; }
        public string? PostcodeZip { get; set; }
        public string? Areacode { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Fax { get; set; }
        public string? Country { get; set; }
        public byte Active { get; set; }
        public byte Affiliate { get; set; }
    }
}
