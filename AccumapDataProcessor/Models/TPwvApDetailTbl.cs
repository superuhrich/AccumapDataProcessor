using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TPwvApDetailTbl
    {
        public string Document { get; set; } = null!;
        public DateTime FolderId { get; set; }
        public int PwrId { get; set; }
        public int PwrDetailId { get; set; }
        public int? OrgId { get; set; }
        public string? Account { get; set; }
        public string? AccountDesc { get; set; }
        public string? AfeNum { get; set; }
        public string? AfeDesc { get; set; }
        public string? CcNum { get; set; }
        public string? CcDesc { get; set; }
        public DateTime? ActvyPerDate { get; set; }
        public decimal? ReportingCurrAmt { get; set; }
        public decimal? LiVolume { get; set; }
        public string? LiRemarks { get; set; }
        public int? GovernAgrId { get; set; }
        public string? GovernAgrTypeCode { get; set; }
        public string? Invoice { get; set; }
        public string? ClientId { get; set; }
        public DateTime? InvcDate { get; set; }
        public int? OnHold { get; set; }
        public decimal? DiscountAmt { get; set; }
        public string? ContinuityCode { get; set; }
        public decimal? Qty { get; set; }
        public string? Uom { get; set; }
        public string? Description { get; set; }
        public decimal? UnitPrice { get; set; }
        public DateTime? ServiceStartDate { get; set; }
        public DateTime? ServiceEndDate { get; set; }
        public string? FieldTicketNumber { get; set; }
        public string? PwrCommodityCode { get; set; }
        public string? PwrCommodityTitle { get; set; }
        public int? PoLineNumber { get; set; }
        public string? WorkOrderNumber { get; set; }
        public string? JvFootnote { get; set; }
        public string? GlSubCode { get; set; }
        public string? UserDefinedTag { get; set; }
        public string? PstProvince { get; set; }
        public decimal? PstAmt { get; set; }
        public string? AssetNumber { get; set; }
    }
}
