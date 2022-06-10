using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class VDimControlGroup
    {
        public string ControlGroupId { get; set; } = null!;
        public string ControlGroupName { get; set; } = null!;
        public string ControlGroupRegion { get; set; } = null!;
        public string? PaResponsibleUserId { get; set; }
        public string? ControlGroupPaResponsibleUser { get; set; }
    }
}
