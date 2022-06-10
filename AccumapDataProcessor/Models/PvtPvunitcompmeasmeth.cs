using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class PvtPvunitcompmeasmeth
    {
        public string Idflownet { get; set; } = null!;
        public string? Idrecparent { get; set; }
        public string Idrec { get; set; } = null!;
        public DateTime? Dttmstart { get; set; }
        public string? Flowdirection { get; set; }
        public string? Methodgas { get; set; }
        public string? Idrecnodegas { get; set; }
        public string? Idrecnodegastk { get; set; }
        public string? Methodhcliq { get; set; }
        public string? Idrecnodehcliq { get; set; }
        public string? Idrecnodehcliqtk { get; set; }
        public string? Methodwater { get; set; }
        public string? Idrecnodewater { get; set; }
        public string? Idrecnodewatertk { get; set; }
        public string? Idrecnodecasinggas { get; set; }
        public string? Idrecnodecasinggastk { get; set; }
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
