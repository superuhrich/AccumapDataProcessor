using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccumapDataProcessor.DapperModels
{
    public class Well
    {
        public string Uwi { get; set; } = null!;
        public DateTime? AbandonmentDate { get; set; }
        public string? ActiveInd { get; set; }
        public string? AssignedField { get; set; }
        public string? BaName { get; set; }
        public decimal? BottomHoleLatitude { get; set; }
        public decimal? BottomHoleLongitude { get; set; }
        public DateTime? CompletionDate { get; set; }
        public decimal? DrillTd { get; set; }
        public string? DrillTdOuom { get; set; }
        public decimal? FinalTd { get; set; }
        public string? FinalTdOuom { get; set; }
        public decimal? KbElev { get; set; }
        public string? KbElevOuom { get; set; }
        public decimal? MaxTvd { get; set; }
        public string? MaxTvdOuom { get; set; }
        public string? OldestStratUnitId { get; set; }
        public string? Operator { get; set; }
        public string? ProfileType { get; set; }
        public string ProvinceState { get; set; } = null!;
        public DateTime? RigReleaseDate { get; set; }
        public DateTime? SpudDate { get; set; }
        public string? StatusType { get; set; }
        public decimal? SurfaceLatitude { get; set; }
        public decimal? SurfaceLongitude { get; set; }
        public string? TdStratUnitId { get; set; }
        public string? WellName { get; set; }
        public string? XCurrentLicensee { get; set; }
        public decimal? XEventNum { get; set; }
        public DateTime? XOnprodDate { get; set; }
        public string? XUwiDisplay { get; set; }
        public decimal? XTdTvd { get; set; }
        public decimal? XLateralLength { get; set; }
        public InteractionStatus PcInteractionStatus { get; set; } = InteractionStatus.Parent;
    }

    public enum InteractionStatus {
        None = 0,
        Parent = 1,
        Child = 2,
    }
}
