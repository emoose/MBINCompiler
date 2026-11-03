using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC51ADA0A7266C725, NameHash = 0x9E56997B)]
    public class GcFishData : NMSTemplate
    {
        [NMS(Index = 10)]
        /* 0x00 */ public NMSString0x10 CatchIncrementsStat;
        [NMS(Index = 7)]
        /* 0x10 */ public GcSeed MissionSeed;
        [NMS(Index = 0)]
        /* 0x20 */ public NMSString0x10 ProductID;
        [NMS(Index = 6)]
        /* 0x30 */ public NMSString0x10 RequiresMissionActive;
        [NMS(Index = 9)]
        /* 0x40 */ public float MissionCatchChanceOverride;
        [NMS(Index = 1)]
        /* 0x44 */ public GcItemQuality Quality;
        [NMS(Index = 2)]
        /* 0x48 */ public GcFishSize Size;
        [NMS(Index = 3)]
        /* 0x4C */ public GcFishingTime Time;
        [NMS(Index = 4, Size = 0x11, EnumType = typeof(GcBiomeType.BiomeEnum))]
        /* 0x50 */ public bool[] Biome;
        [NMS(Index = 8)]
        /* 0x61 */ public bool MissionMustAlsoBeSelected;
        [NMS(Index = 5)]
        /* 0x62 */ public bool NeedsStorm;
    }
}
