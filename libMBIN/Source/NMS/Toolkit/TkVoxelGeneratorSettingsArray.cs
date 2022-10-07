using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x1DF205AFA78D885A, NameHash = 0x62EA167F11DA4F86)]
    public class TkVoxelGeneratorSettingsArray : NMSTemplate
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
        [NMS(Size = 0x15, EnumType = typeof(TerrainSettingsEnum))]
        /* 0x0 */ public TkVoxelGeneratorSettingsElement[] TerrainSettings;
    }
}
