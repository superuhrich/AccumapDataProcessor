using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TQbyteAccount
    {
        public DateTime? CreateDate { get; set; }
        public string? CreateUser { get; set; }
        public string? MajorAcct { get; set; }
        public string? MinorAcct { get; set; }
        public string? AcctDesc { get; set; }
        public string? AfeReqdFlag { get; set; }
        public string? CcReqdFlag { get; set; }
        public string? VolReqdFlag { get; set; }
        public string? ActvyDateReqdFlag { get; set; }
        public string? ContinuityReqdFlag { get; set; }
        public string? EnvAllowedFlag { get; set; }
        public string? AltClientReqdFlag { get; set; }
        public string? AltGlCodeReqdFlag { get; set; }
        public string? CtrlEquipReqdFlag { get; set; }
        public string? BudgetInVolumesFlag { get; set; }
        public string? OracleAssetsReqdFlag { get; set; }
        public string? GlSubCodeReqdFlag { get; set; }
        public string? JibFootnoteReqdFlag { get; set; }
        public string? EnergyContentReqdFlag { get; set; }
        public string? ContEquipFootnoteReqdFlag { get; set; }
        public string? ProcessOnlyAcctFlag { get; set; }
        public string? UserDefinedTagFlag { get; set; }
        public string? ExcludeAfeCostsFromCcOh { get; set; }
        public DateTime? LastUpdtDate { get; set; }
        public string? LastUpdtUser { get; set; }
        public string? CtrlAcctTypeCode { get; set; }
        public string? ProdCode { get; set; }
        public decimal? GstFactor { get; set; }
        public string? PascAcct { get; set; }
        public string? DefaultCurrTypeCode { get; set; }
        public string? CurrConversionRuleCode { get; set; }
        public DateTime? TermDate { get; set; }
        public string? TermUser { get; set; }
        public string? ToCapitalMajorAcct { get; set; }
        public string? ToCapitalMinorAcct { get; set; }
        public string? ToExpenseMajorAcct { get; set; }
        public string? ToExpenseMinorAcct { get; set; }
        public string? CurrCode { get; set; }
        public string? DdaRuleCode { get; set; }
        public string? AccountCompanyCode { get; set; }
        public string? AccrualMajorAcct { get; set; }
        public string? AccrualMinorAcct { get; set; }
        public string? InvoiceApprovalCostCategory { get; set; }
        public string? UserDefinedTagPrompt { get; set; }
        public string? EnvCodePrompt { get; set; }
        public string? ReOciFlag { get; set; }
    }
}
