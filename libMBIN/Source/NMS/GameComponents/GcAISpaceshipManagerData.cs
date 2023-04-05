using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9B751B547A197A93, NameHash = 0x785665CB6C017B4C)]
    public class GcAISpaceshipManagerData : NMSTemplate
    {
        [NMS(Size = 0x5, EnumType = typeof(GcRealityCommonFactions.AIFactionEnum))]
        /* 0x00 */ public GcAISpaceshipModelDataArray[] SystemSpaceships;
        /* 0x50 */ public GcAISpaceshipModelData SentinelCrashSiteShip;
    }
}
