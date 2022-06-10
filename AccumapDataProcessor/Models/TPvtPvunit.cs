using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TPvtPvunit
    {
        public string Idflownet { get; set; } = null!;
        public string Idrec { get; set; } = null!;
        public string? Name { get; set; }
        public string? Nameshort { get; set; }
        public string? Typ1 { get; set; }
        public string? Typ2 { get; set; }
        public string? Typdisphcliq { get; set; }
        public string? Dispproductname { get; set; }
        public string? Idrecroutesetroutecalc { get; set; }
        public string? Idrecroutesetroutecalctk { get; set; }
        public string? Idrecfacilitycalc { get; set; }
        public string? Idrecfacilitycalctk { get; set; }
        public string? Typregulatory { get; set; }
        public string? Typpa { get; set; }
        public double? Displaysizefactor { get; set; }
        public DateTime? Dttmstart { get; set; }
        public DateTime? Dttmend { get; set; }
        public DateTime? Dttmhide { get; set; }
        public double? Elevation { get; set; }
        public string? Unitidregulatory { get; set; }
        public string? Unitidpa { get; set; }
        public string? Unitida { get; set; }
        public string? Unitidb { get; set; }
        public string? Unitidc { get; set; }
        public short? Purchaser { get; set; }
        public short? Operated { get; set; }
        public string? Operator { get; set; }
        public string? Operatorida { get; set; }
        public string? Com { get; set; }
        public string? Legalsurfloc { get; set; }
        public string? Division { get; set; }
        public string? Divisioncode { get; set; }
        public string? District { get; set; }
        public string? Country { get; set; }
        public string? Area { get; set; }
        public string? Field { get; set; }
        public string? Fieldcode { get; set; }
        public string? Fieldoffice { get; set; }
        public string? Fieldofficecode { get; set; }
        public string? Stateprov { get; set; }
        public string? County { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public string? Latlongsource { get; set; }
        public string? Latlongdatum { get; set; }
        public int? Utmgridzone { get; set; }
        public string? Utmsource { get; set; }
        public double? Utmx { get; set; }
        public double? Utmy { get; set; }
        public string? Lease { get; set; }
        public string? Leaseida { get; set; }
        public string? Locationtyp { get; set; }
        public string? Platform { get; set; }
        public string? Padcode { get; set; }
        public string? Padname { get; set; }
        public string? Slot { get; set; }
        public string? Govauthority { get; set; }
        public string? Costcenterida { get; set; }
        public string? Costcenteridb { get; set; }
        public string? Sortbyuser { get; set; }
        public short? Priority { get; set; }
        public string? Timezone { get; set; }
        public string? Idrecresp1 { get; set; }
        public string? Idrecresp1tk { get; set; }
        public string? Idrecresp2 { get; set; }
        public string? Idrecresp2tk { get; set; }
        public string? Keymigrationsource { get; set; }
        public string? Typmigrationsource { get; set; }
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
