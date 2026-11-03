using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x816993EB69267DD2, NameHash = 0x294639B)]
    public class GcBiomeListPerStarType : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x5, EnumType = typeof(GcGalaxyStarTypes.GalaxyStarTypeEnum))]
        /* 0x000 */ public GcBiomeList[] StarType;
        [NMS(Index = 2)]
        /* 0x2A8 */ public GcBiomeList AbandonedYellow;
        [NMS(Index = 1)]
        /* 0x330 */ public GcBiomeList LushYellow;
        [NMS(Index = 4, Size = 0x4, EnumType = typeof(GcPlanetLife.LifeSettingEnum))]
        /* 0x3B8 */ public float[] AbandonedLifeChance;
        [NMS(Index = 3, Size = 0x4, EnumType = typeof(GcPlanetLife.LifeSettingEnum))]
        /* 0x3C8 */ public float[] LifeChance;
        [NMS(Index = 5)]
        /* 0x3D8 */ public float ConvertDeadToWeird;
    }
}
