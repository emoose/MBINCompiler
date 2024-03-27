namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x89AB0100FEC886B9, NameHash = 0x60B0A451EF1759F9)]
    public class TkVoxelGeneratorSettingsTypes : NMSTemplate
    {
        // size: 0x15
        public enum TerrainSettingsEnum : uint {
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
            DesertPrime,
        }
        /* 0x0 */ public TerrainSettingsEnum TerrainSettings;
    }
}
