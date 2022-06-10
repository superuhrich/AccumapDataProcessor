using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class PvtPvunitcomp
    {
        public string Idflownet { get; set; } = null!;
        public string? Idrecparent { get; set; }
        public string Idrec { get; set; } = null!;
        public DateTime? Dttmstartalloc { get; set; }
        public DateTime? Dttmend { get; set; }
        public DateTime? Dttmonprod { get; set; }
        public DateTime? Dttmfirstsale { get; set; }
        public DateTime? Dttmflowbackstart { get; set; }
        public DateTime? Dttmflowbackend { get; set; }
        public DateTime? Dttmabandon { get; set; }
        public string? Completionname { get; set; }
        public string? Permanentid { get; set; }
        public string? Compidregulatory { get; set; }
        public string? Compidpa { get; set; }
        public string? Completionlicensee { get; set; }
        public string? Completionlicenseno { get; set; }
        public DateTime? Dttmlicense { get; set; }
        public string? Compida { get; set; }
        public string? Compidb { get; set; }
        public string? Compidc { get; set; }
        public string? Compidd { get; set; }
        public string? Completionide { get; set; }
        public string? Completioncode { get; set; }
        public string? Wellname { get; set; }
        public string? Wellidregulatory { get; set; }
        public string? Wellidpa { get; set; }
        public string? Welllicenseno { get; set; }
        public string? Wellida { get; set; }
        public string? Wellidb { get; set; }
        public string? Wellidc { get; set; }
        public string? Wellidd { get; set; }
        public string? Wellide { get; set; }
        public string? Importid1 { get; set; }
        public string? Importtyp1 { get; set; }
        public string? Importid2 { get; set; }
        public string? Importtyp2 { get; set; }
        public string? Exportid1 { get; set; }
        public string? Exporttyp1 { get; set; }
        public string? Exportid2 { get; set; }
        public string? Exporttyp2 { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public string? Latlongsource { get; set; }
        public string? Latlongdatum { get; set; }
        public string? Entryreqperiodfluidlevel { get; set; }
        public string? Entryreqperiodparam { get; set; }
        public string? Usertxt1 { get; set; }
        public string? Usertxt2 { get; set; }
        public string? Usertxt3 { get; set; }
        public string? Usertxt4 { get; set; }
        public string? Usertxt5 { get; set; }
        public double? Usernum1 { get; set; }
        public double? Usernum2 { get; set; }
        public double? Usernum3 { get; set; }
        public double? Usernum4 { get; set; }
        public double? Usernum5 { get; set; }
        public DateTime? Userdttm1 { get; set; }
        public DateTime? Userdttm2 { get; set; }
        public DateTime? Userdttm3 { get; set; }
        public DateTime? Userdttm4 { get; set; }
        public DateTime? Userdttm5 { get; set; }
        public string? Keymigrationsource { get; set; }
        public string? Typmigrationsource { get; set; }
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
