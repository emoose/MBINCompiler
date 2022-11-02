namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x55E9CAC0F4ECD931, NameHash = 0x60B0A451EF1759F9)]
    public class TkVoxelGeneratorSettingsTypes : NMSTemplate
    {
        // size: 0x15
        public enum TerrainSettingsEnum {
            FloatingIslands,
            GrandCanyon,
            MountainRavines,
            HugeArches,
            Alien,
            Craters,
            Caverns,
            Alpine,
            LilyPad,
            Desert,
            WaterworldPrime,
            FloatingIslandsPrime,
            GrandCanyonPrime,
            MountainRavinesPrime,
            HugeArchesPrime,
            AlienPrime,
            CratersPrime,
            CavernsPrime,
            AlpinePrime,
            LilyPadPrime,
            DesertPrime
        }
        /* 0x0 */ public TerrainSettingsEnum TerrainSettings;
    }
}
