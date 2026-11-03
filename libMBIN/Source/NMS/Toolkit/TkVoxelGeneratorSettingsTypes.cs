namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xB7F7C51FCDEB07D8, NameHash = 0x8DBE54DD)]
    public class TkVoxelGeneratorSettingsTypes : NMSTemplate
    {
        // size: 0x1F
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
            FloatingIslandsPurple,
            GrandCanyonPurple,
            MountainRavinesPurple,
            HugeArchesPurple,
            AlienPurple,
            CratersPurple,
            CavernsPurple,
            AlpinePurple,
            LilyPadPurple,
            DesertPurple,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public TerrainSettingsEnum TerrainSettings;
    }
}
