using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TQbyteMajorAccount
    {
        public DateTime? CreateDate { get; set; }
        public string? CreateUser { get; set; }
        public string? MajorAcct { get; set; }
        public string? MajorAcctDesc { get; set; }
        public string? ClassCode { get; set; }
        public string? GrossOrNetCode { get; set; }
        public string? AfeReqdDfltFlag { get; set; }
        public string? CcReqdDfltFlag { get; set; }
        public string? VolReqdDfltFlag { get; set; }
        public string? ActvyDateReqdDfltFlag { get; set; }
        public string? ContinuityReqdDfltFlag { get; set; }
        public string? EnvAllowedDfltFlag { get; set; }
        public string? AltClientReqdDfltFlag { get; set; }
        public string? AltGlCodeReqdDfltFlag { get; set; }
        public string? CtrlEquipReqdDfltFlag { get; set; }
        public DateTime? LastUpdtDate { get; set; }
        public string? LastUpdtUser { get; set; }
        public string? NetMajorAcct { get; set; }
        public string? CtrlAcctTypeDfltCode { get; set; }
        public string? AccrualMajorAcct { get; set; }
        public string? AccrualMinorAcct { get; set; }
        public string? DefaultCurrTypeDfltCode { get; set; }
        public string? CurrConvRuleDfltCode { get; set; }
        public DateTime? TermDate { get; set; }
        public string? TermUser { get; set; }
        public string? TaxClassRuleFlag { get; set; }
        public string? GlSubCodeReqdDfltFlag { get; set; }
        public string? JibFootnoteReqdDfltFlag { get; set; }
        public string? ContEquipFootReqdDfltFlag { get; set; }
        public string? ReOciDfltFlag { get; set; }
    }
}
