using System;
using System.Collections.Generic;

namespace AccumapDataProcessor.Models
{
    public partial class TBudgetEntSegment
    {
        public string ObjectId { get; set; } = null!;
        public string ParentId { get; set; } = null!;
        public int SegmentIndex { get; set; }
        public DateTime StartDate { get; set; }
        public byte StartDateLinked { get; set; }
        public DateTime EndDate { get; set; }
        public byte TimeCalculated { get; set; }
        public double Qi { get; set; }
        public byte QiLinked { get; set; }
        public double Di { get; set; }
        public byte DiLinked { get; set; }
        public byte DiCalculated { get; set; }
        public double N { get; set; }
        public byte NLinked { get; set; }
        public double Ei { get; set; }
        public double Qf { get; set; }
        public byte QfLinked { get; set; }
        public byte QfCalculated { get; set; }
        public double MaxRate { get; set; }
        public byte MaxRateLinked { get; set; }
        public double StartCum { get; set; }
        public double EndCum { get; set; }
        public double DenominatorStartCum { get; set; }
        public double DenominatorEndCum { get; set; }
        public byte DenominatorVolumeCalculated { get; set; }
        public double StartTime { get; set; }
        public double EndTime { get; set; }
        public byte VolumeCalculated { get; set; }
        public double Df { get; set; }
        public byte DfCalculated { get; set; }
        public double FinalVolume { get; set; }
        public byte FinalVolumeLinked { get; set; }
        public byte FinalVolumeCalculated { get; set; }
        public int ErrorType { get; set; }
    }
}
