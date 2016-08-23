namespace MBINCompiler.Models.Structs
{
    public class GcStats : NMSTemplate
    {
        [NMSAttribute(Size = 4)]
        public GcStatsGroup[] Stats;
    }
}
