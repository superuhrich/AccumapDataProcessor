using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TDimControlGroup
    {
        public string? ControlGroupId { get; set; }
        public string? ControlGroupName { get; set; }
        public string? ControlGroupRegion { get; set; }
        public string? PaResponsibleUserId { get; set; }
        public string? ControlGroupPaResponsibleUser { get; set; }
    }
}
