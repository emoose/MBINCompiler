namespace MBINCompiler.Models.Structs
{
    public class GcStatsEntry : NMSTemplate
    {
        public GcStatsTypes StatsType;
        public Colour Colour;
        public float RangeMin;
        public float RangeMax;
        public bool LessIsBetter;

        [NMS(Ignore = true)]
        public int EmptyNode1;
    }
}
