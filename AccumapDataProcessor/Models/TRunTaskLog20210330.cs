using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TRunTaskLog20210330
    {
        public long RunTaskKey { get; set; }
        public Guid RunId { get; set; }
        public string? Job { get; set; }
        public string? Cube { get; set; }
        public string? Package { get; set; }
        public string? Task { get; set; }
        public string? Description { get; set; }
        public string? Message { get; set; }
        public string? Information { get; set; }
        public string? FailedTask { get; set; }
        public string? ExceptionMsg { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? EndDateCalc { get; set; }
        public int? DurationSec { get; set; }
        public int? InsertedCount { get; set; }
        public int? UpdatedCount { get; set; }
        public int? DeletedCount { get; set; }
        public double? Total { get; set; }
        public string? Data01 { get; set; }
        public string? Data02 { get; set; }
        public string? Data03 { get; set; }
        public double? DataValue01 { get; set; }
        public double? DataValue02 { get; set; }
        public double? DataValue03 { get; set; }
        public int? StatusCode { get; set; }
        public string Status { get; set; } = null!;
        public string Username { get; set; } = null!;
    }
}
