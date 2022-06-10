using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class CustomGroupingsLeaf
    {
        public int Id { get; set; }
        public byte ImportType { get; set; }
        public byte ImportStatusId { get; set; }
        public int? BatchId { get; set; }
        public string BatchTag { get; set; } = null!;
        public int ErrorCode { get; set; }
        public string? Code { get; set; }
        public string? Name { get; set; }
        public string? NewCode { get; set; }
        public string? CostCentreType { get; set; }
        public string? Group1 { get; set; }
        public string? Group2 { get; set; }
        public string? Group3 { get; set; }
        public string? Group4 { get; set; }
        public string? Group5 { get; set; }
        public string? Group6 { get; set; }
        public string? Group7 { get; set; }
        public string? Group8 { get; set; }
        public string? Group9 { get; set; }
        public string? Group10 { get; set; }
    }
}
