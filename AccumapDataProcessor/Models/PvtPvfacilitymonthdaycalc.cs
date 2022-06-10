using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class PvtPvfacilitymonthdaycalc
    {
        public string Idflownet { get; set; } = null!;
        public string? Idrecparent { get; set; }
        public string Idrec { get; set; } = null!;
        public string? Idrecfacility { get; set; }
        public string? Idrecfacilitytk { get; set; }
        public DateTime? Dttm { get; set; }
        public int? Year { get; set; }
        public int? Month { get; set; }
        public int? Dayofmonth { get; set; }
        public double? Volprodhcliq { get; set; }
        public double? Volprodgas { get; set; }
        public double? Volprodgasplusgaseq { get; set; }
        public double? Volprodwater { get; set; }
        public double? Volprodsand { get; set; }
        public double? Volnewprodgathhcliq { get; set; }
        public double? Volnewprodgathgas { get; set; }
        public double? Volnewprodgathgasplusgaseq { get; set; }
        public double? Volnewprodgathwater { get; set; }
        public double? Volnewprodgathsand { get; set; }
        public double? Balfacthcliq { get; set; }
        public double? Balfactgas { get; set; }
        public double? Balfactgasplusgaseq { get; set; }
        public double? Balfactwater { get; set; }
        public double? Balfactsand { get; set; }
        public double? Volbalhcliq { get; set; }
        public double? Volbalgas { get; set; }
        public double? Volbalgasplusgaseq { get; set; }
        public double? Volbalwater { get; set; }
        public double? Volbalsand { get; set; }
        public short? Balanced { get; set; }
        public short? Balhcliq { get; set; }
        public short? Balgas { get; set; }
        public short? Balgasplusgaseq { get; set; }
        public short? Balwater { get; set; }
        public short? Balsand { get; set; }
        public double? Volinrecovhcliq { get; set; }
        public double? Volinrecovgas { get; set; }
        public double? Volinrecovgasplusgaseq { get; set; }
        public double? Volinrecovwater { get; set; }
        public double? Volinrecovsand { get; set; }
        public double? Volinotherhcliq { get; set; }
        public double? Volinothergas { get; set; }
        public double? Volinothergasplusgaseq { get; set; }
        public double? Volinotherwater { get; set; }
        public double? Volinothersand { get; set; }
        public double? Voloutconsumehcliq { get; set; }
        public double? Voloutconsumegas { get; set; }
        public double? Voloutconsumegasplusgaseq { get; set; }
        public double? Voloutconsumewater { get; set; }
        public double? Voloutconsumesand { get; set; }
        public double? Voloutinjectrecovhcliq { get; set; }
        public double? Voloutinjectrecovgas { get; set; }
        public double? Voloutinjectrecovgasplusgaseq { get; set; }
        public double? Voloutinjectrecovwater { get; set; }
        public double? Voloutinjectrecovsand { get; set; }
        public double? Voloutotherhcliq { get; set; }
        public double? Voloutothergas { get; set; }
        public double? Voloutothergasplusgaseq { get; set; }
        public double? Voloutotherwater { get; set; }
        public double? Voloutothersand { get; set; }
        public double? Volstartremainrecovhcliq { get; set; }
        public double? Volstartremainrecovgas { get; set; }
        public double? Volstartremainrecovgasplusgeq { get; set; }
        public double? Volstartremainrecovwater { get; set; }
        public double? Volstartremainrecovsand { get; set; }
        public double? Volendremainrecovhcliq { get; set; }
        public double? Volendremainrecovgas { get; set; }
        public double? Volendremainrecovgasplusgeq { get; set; }
        public double? Volendremainrecovwater { get; set; }
        public double? Volendremainrecovsand { get; set; }
        public double? Volstartinvhcliq { get; set; }
        public double? Volstartinvhcliqgaseq { get; set; }
        public double? Volstartinvwater { get; set; }
        public double? Volstartinvsand { get; set; }
        public double? Volendinvhcliq { get; set; }
        public double? Volendinvhcliqgaseq { get; set; }
        public double? Volendinvwater { get; set; }
        public double? Volendinvsand { get; set; }
        public double? Volchginvhcliq { get; set; }
        public double? Volchginvhcliqgaseq { get; set; }
        public double? Volchginvwater { get; set; }
        public double? Volchginvsand { get; set; }
        public double? Volstvgas { get; set; }
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
