using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class VVerifyVolumesQbyteVsVolumeCube
    {
        public string TargetAccount { get; set; } = null!;
        public int? GrossNetKey { get; set; }
        public string? ActivityYear { get; set; }
        public string? ActivityMonth { get; set; }
        public double? QbyteMetricVolume { get; set; }
        public double? VolumesCubeMetricVolume { get; set; }
        public double MetricVolumeDiff { get; set; }
        public double? QbyteBoeVolume { get; set; }
        public double? VolumesCubeBoeVolume { get; set; }
        public double BoeVolumeDiff { get; set; }
        public double? QbyteImperialVolume { get; set; }
        public double? VolumesCubeImperialVolume { get; set; }
        public double ImperialVolumeDiff { get; set; }
        public double? QbyteMcfeVolume { get; set; }
        public double? VolumesCubeMcfeVolume { get; set; }
        public double McfeVolumeDiff { get; set; }
    }
}
