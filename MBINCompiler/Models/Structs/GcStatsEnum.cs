namespace MBINCompiler.Models.Structs
{
    public class GcStatsEnum : NMSTemplate     // size: 0x48
    {
        public int Stat;
        public string[] StatValues()
        {
            return new[]
            {
                "None", "INACTIVE", "BINOC_INTERACTABLE", "PLANTS_PLANTED", "SALVAGE_LOOTED"
            };
        }
    }
}
