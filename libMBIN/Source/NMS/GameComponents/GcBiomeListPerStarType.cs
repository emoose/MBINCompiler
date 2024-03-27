using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDB25A53E0EB949F6, NameHash = 0xFABB438AC71DAB8D)]
    public class GcBiomeListPerStarType : NMSTemplate
    {
        [NMS(Size = 0x4, EnumType = typeof(GcGalaxyStarTypes.GalaxyStarTypeEnum))]
        /* 0x000 */ public GcBiomeList[] StarType;
        /* 0x200 */ public GcBiomeList LushYellow;
        /* 0x280 */ public GcBiomeList AbandonedYellow;
        [NMS(Size = 0x4, EnumType = typeof(GcPlanetLife.LifeSettingEnum))]
        /* 0x300 */ public float[] LifeChance;
        [NMS(Size = 0x4, EnumType = typeof(GcPlanetLife.LifeSettingEnum))]
        /* 0x310 */ public float[] AbandonedLifeChance;
        /* 0x320 */ public float ConvertDeadToWeird;
    }
}
