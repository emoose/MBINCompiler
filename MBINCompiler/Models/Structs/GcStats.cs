namespace MBINCompiler.Models.Structs
{
    public class GcStats : NMSTemplate
    {
        [NMS(Size = 4)]
        public GcStatsGroup[] Stats;
    }
}
