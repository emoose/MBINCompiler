using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x53B6F193A051412B, NameHash = 0x785665CB6C017B4C)]
    public class GcAISpaceshipManagerData : NMSTemplate
    {
        [NMS(Size = 0x5, EnumType = typeof(GcRealityCommonFactions.AIFactionEnum))]
        /* 0x0 */ public GcAISpaceshipModelDataArray[] SystemSpaceships;
    }
}
