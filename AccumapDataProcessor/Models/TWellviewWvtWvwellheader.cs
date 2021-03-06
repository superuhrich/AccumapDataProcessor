using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TWellviewWvtWvwellheader
    {
        public string Idwell { get; set; } = null!;
        public string? Agent { get; set; }
        public string? Area { get; set; }
        public string? Basin { get; set; }
        public string? Basincode { get; set; }
        public string? Com { get; set; }
        public string? Country { get; set; }
        public string? County { get; set; }
        public string? Currentwellstatus1 { get; set; }
        public string? Currentwellstatus2 { get; set; }
        public string? Directionstowell { get; set; }
        public string? District { get; set; }
        public string? Division { get; set; }
        public string? Divisioncode { get; set; }
        public DateTime? Dttmabandon { get; set; }
        public DateTime? Dttmfirstprod { get; set; }
        public DateTime? Dttmrr { get; set; }
        public DateTime? Dttmspud { get; set; }
        public DateTime? Dttmwellclass { get; set; }
        public DateTime? Dttmwelllic { get; set; }
        public double? Elvcasflange { get; set; }
        public double? Elvground { get; set; }
        public double? Elvlat { get; set; }
        public double? Elvmudline { get; set; }
        public double? Elvorigkb { get; set; }
        public double? Elvtubhead { get; set; }
        public short? Environmentsensitive { get; set; }
        public double? Ewdist { get; set; }
        public string? Ewflag { get; set; }
        public string? Fieldcode { get; set; }
        public string? Fieldname { get; set; }
        public string? Fieldoffice { get; set; }
        public string? Fieldofficecode { get; set; }
        public string? Govauthority { get; set; }
        public short? Hih2s { get; set; }
        public short? Hisitp { get; set; }
        public string? Idrecelvhistory { get; set; }
        public string? Idrecelvhistorytk { get; set; }
        public double? Latitude { get; set; }
        public string? Latlongdatum { get; set; }
        public string? Latlongsource { get; set; }
        public string? Lease { get; set; }
        public string? Leasecode { get; set; }
        public string? Legalsurveyloc { get; set; }
        public string? Legalsurveysubtyp { get; set; }
        public string? Legalsurveytyp { get; set; }
        public double? Localtimezone { get; set; }
        public string? Locationnote { get; set; }
        public string? Locationref { get; set; }
        public short? Locationsensitive { get; set; }
        public string? Locationtyp { get; set; }
        public double? Longitude { get; set; }
        public double? Nsdist { get; set; }
        public string? Nsflag { get; set; }
        public short? Operated { get; set; }
        public string? Operator { get; set; }
        public string? Operatorcode { get; set; }
        public string? Padcode { get; set; }
        public string? Padname { get; set; }
        public string? Platform { get; set; }
        public string? Primaryfluiddes { get; set; }
        public short? Problemflag { get; set; }
        public string? Riskclass { get; set; }
        public string? Slot { get; set; }
        public string? Stateprov { get; set; }
        public string? Surfacerights { get; set; }
        public double? Towndist { get; set; }
        public string? Townflag { get; set; }
        public string? Townname { get; set; }
        public string? Townstateprov { get; set; }
        public short? Userboolean1 { get; set; }
        public short? Userboolean2 { get; set; }
        public short? Userboolean3 { get; set; }
        public short? Userboolean4 { get; set; }
        public short? Userboolean5 { get; set; }
        public DateTime? Userdttm1 { get; set; }
        public DateTime? Userdttm2 { get; set; }
        public DateTime? Userdttm3 { get; set; }
        public DateTime? Userdttm4 { get; set; }
        public DateTime? Userdttm5 { get; set; }
        public double? Usernum1 { get; set; }
        public double? Usernum2 { get; set; }
        public double? Usernum3 { get; set; }
        public double? Usernum4 { get; set; }
        public double? Usernum5 { get; set; }
        public double? Usernum6 { get; set; }
        public string? Usertxt1 { get; set; }
        public string? Usertxt10 { get; set; }
        public string? Usertxt2 { get; set; }
        public string? Usertxt3 { get; set; }
        public string? Usertxt4 { get; set; }
        public string? Usertxt5 { get; set; }
        public string? Usertxt6 { get; set; }
        public string? Usertxt7 { get; set; }
        public string? Usertxt8 { get; set; }
        public string? Usertxt9 { get; set; }
        public int? Utmgridzone { get; set; }
        public string? Utmsource { get; set; }
        public double? Utmx { get; set; }
        public double? Utmy { get; set; }
        public double? Waterdepth { get; set; }
        public string? Waterdepthref { get; set; }
        public string? Wellclass { get; set; }
        public string? Wellconfig { get; set; }
        public string? Wellida { get; set; }
        public string? Wellidb { get; set; }
        public string? Wellidc { get; set; }
        public string? Wellidd { get; set; }
        public string? Wellide { get; set; }
        public string? Welllicensee { get; set; }
        public string? Welllicenseno { get; set; }
        public string? Wellname { get; set; }
        public string? Welltyp1 { get; set; }
        public string? Welltyp2 { get; set; }
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
        public DateTime? Sysmoddatedb { get; set; }
        public string? Sysmoduserdb { get; set; }
        public string? Syssecuritytyp { get; set; }
        public DateTime? Syslockdatemaster { get; set; }
    }
}
