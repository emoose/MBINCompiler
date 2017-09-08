namespace MBINCompiler.Models.Structs
{
    [NMS(Size = 0xC)]
    public class GcStatsBonus : NMSTemplate
    {
        public GcStatsTypes StatsTypes;
        public float Bonus;
        public int Level;
    }
}
