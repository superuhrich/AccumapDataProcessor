﻿using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class PvtPvunitcompwhcut
    {
        public string Idflownet { get; set; } = null!;
        public string? Idrecparent { get; set; }
        public string Idrec { get; set; } = null!;
        public DateTime? Dttmstart { get; set; }
        public double? Bsw { get; set; }
        public double? Sandcut { get; set; }
        public string? Com { get; set; }
        public short? Syslockmeui { get; set; }
        public short? Syslockchildrenui { get; set; }
        public short? Syslockme { get; set; }
        public short? Syslockchildren { get; set; }
        public DateTime? Syslockdate { get; set; }
        public DateTime? Sysmoddate { get; set; }
        public string? Sysmoduser { get; set; }
        public DateTime? Syscreatedate { get; set; }
        public string? Syscreateuser { get; set; }
        public string? Systag { get; set; }
    }
}
