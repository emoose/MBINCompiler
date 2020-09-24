using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x324, GUID = 0x6C8F5A786241F589, NameHash = 0xFABB438AC71DAB8D)]
    public class GcBiomeListPerStarType : NMSTemplate
    {
        [NMS(Size = 4, EnumType = typeof(GcGalaxyStarTypes.GalaxyStarTypeEnum))]
        /* 0x000 */ public GcBiomeList[] StarType;
        /* 0x200 */ public GcBiomeList LushYellow;
        /* 0x280 */ public GcBiomeList AbandonedYellow;
        [NMS(Size = 4, EnumType = typeof(GcGalaxyStarTypes.GalaxyStarTypeEnum))]
        /* 0x300 */ public float[] LifeChance;
        [NMS(Size = 4, EnumType = typeof(GcGalaxyStarTypes.GalaxyStarTypeEnum))]
        /* 0x310 */ public float[] AbandonedLifeChance;
        /* 0x324 */ public float ConvertDeadToWeird;
    }
}
