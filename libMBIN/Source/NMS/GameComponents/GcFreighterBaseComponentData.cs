using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x98BF723C39B6BB58, NameHash = 0x8201F7ADD0F5959D)]
    public class GcFreighterBaseComponentData : NMSTemplate
    {
        // size: 0x2
        public enum FreighterBaseGenerationModeEnum {
            Prefab,
            WFC
        }
        /* 0x00 */ public FreighterBaseGenerationModeEnum FreighterBaseGenerationMode;
        // size: 0x4
        public enum FreighterBaseOptionsEnum {
            C,
            B,
            A,
            S
        }
        [NMS(Size = 0x4, EnumType = typeof(FreighterBaseOptionsEnum))]
        /* 0x08 */ public GcFreighterBaseOptions[] FreighterBaseOptions;
        /* 0x48 */ public NMSString0x80 FreighterBaseForPlayerReset;
        /* 0xC8 */ public NMSString0x80 WFCBuildingFile;
    }
}
