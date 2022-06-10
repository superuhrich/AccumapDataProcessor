using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TWellviewWvtWvjobafe
    {
        public string Idwell { get; set; } = null!;
        public string? Idrecparent { get; set; }
        public string Idrec { get; set; } = null!;
        public string? Afenumber { get; set; }
        public string? Afenumbersupp { get; set; }
        public string? Afestatus { get; set; }
        public string? Com { get; set; }
        public string? Costtyp { get; set; }
        public DateTime? Dttmafe { get; set; }
        public DateTime? Dttmafeclose { get; set; }
        public short? Exclude { get; set; }
        public string? Projectname { get; set; }
        public string? Projectrefnumber { get; set; }
        public string? Typ { get; set; }
        public double? Workingint { get; set; }
        public string? Workingintnote { get; set; }
        public int? Sysseq { get; set; }
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
