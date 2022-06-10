using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TQbyteProvince
    {
        public string? Code { get; set; }
        public string? CountryCode { get; set; }
        public string? Name { get; set; }
        public decimal? AcToHaFactor { get; set; }
        public decimal? HaToAcFactor { get; set; }
        public string? ProvinceComment { get; set; }
        public decimal? FormationBaId { get; set; }
    }
}
