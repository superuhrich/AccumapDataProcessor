﻿using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TStgProdviewGroupPointDoi
    {
        public string? Idflownet { get; set; }
        public string? Idrecparent { get; set; }
        public DateTime? Dttmstart { get; set; }
        public DateTime Dttmend { get; set; }
        public string? Typ1 { get; set; }
        public string? BaName { get; set; }
        public decimal? WorkingInterest { get; set; }
        public string? Refidb { get; set; }
    }
}
