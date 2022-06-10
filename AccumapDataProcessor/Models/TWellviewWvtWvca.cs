using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TWellviewWvtWvca
    {
        public string Idwell { get; set; } = null!;
        public string Idrec { get; set; } = null!;
        public string? Centralizers { get; set; }
        public double? Centralizersstandoffavg { get; set; }
        public double? Centralizersstandoffmin { get; set; }
        public string? Com { get; set; }
        public string? Contractor { get; set; }
        public double? Depthbtm { get; set; }
        public double? Depthcutpull { get; set; }
        public string? Des { get; set; }
        public DateTime? Dttmcutpull { get; set; }
        public DateTime? Dttmonbottom { get; set; }
        public DateTime? Dttmoutofhole { get; set; }
        public DateTime? Dttmpickup { get; set; }
        public DateTime? Dttmpull { get; set; }
        public DateTime? Dttmrun { get; set; }
        public string? Idrecjobpull { get; set; }
        public string? Idrecjobpulltk { get; set; }
        public string? Idrecjobrun { get; set; }
        public string? Idrecjobruntk { get; set; }
        public string? Idrecwellbore { get; set; }
        public string? Idrecwellboretk { get; set; }
        public string? Latposition { get; set; }
        public string? Notecutpull { get; set; }
        public double? Operatingpresslimit { get; set; }
        public short? Proposedcutpull { get; set; }
        public short? Proposedpull { get; set; }
        public short? Proposedrun { get; set; }
        public string? Pullreason { get; set; }
        public string? Pullreasondetail { get; set; }
        public string? Reasoncutpull { get; set; }
        public string? Scratchers { get; set; }
        public double? Stringwtdown { get; set; }
        public double? Stringwtup { get; set; }
        public double? Tension { get; set; }
        public double? Travelequipwt { get; set; }
        public string? Usertxt1 { get; set; }
        public string? Usertxt2 { get; set; }
        public string? Usertxt3 { get; set; }
        public double? Volumeshoetrack { get; set; }
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
