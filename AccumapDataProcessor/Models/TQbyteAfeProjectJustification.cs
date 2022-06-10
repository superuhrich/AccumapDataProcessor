using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TQbyteAfeProjectJustification
    {
        public DateTime? CreateDate { get; set; }
        public string? CreateUser { get; set; }
        public string? AfeNum { get; set; }
        public decimal? AfeProjJustLineId { get; set; }
        public string? AfeProjJustDesc { get; set; }
        public string? LastUpdateUser { get; set; }
        public DateTime? LastUpdateDate { get; set; }
    }
}
