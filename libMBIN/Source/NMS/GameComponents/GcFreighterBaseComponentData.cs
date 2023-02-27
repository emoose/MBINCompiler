using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF6A553967FD2E51B, NameHash = 0x8201F7ADD0F5959D)]
    public class GcFreighterBaseComponentData : NMSTemplate
    {
        // size: 0x2
        public enum FreighterBaseGenerationModeEnum : uint {
            Prefab,
            WFC,
        }
        /* 0x00 */ public FreighterBaseGenerationModeEnum FreighterBaseGenerationMode;
        [NMS(Size = 0x4, EnumType = typeof(GcInventoryClass.InventoryClassEnum))]
        /* 0x08 */ public GcFreighterBaseOptions[] FreighterBaseOptions;
        /* 0x48 */ public NMSString0x80 FreighterBaseForPlayerReset;
        /* 0xC8 */ public NMSString0x80 WFCBuildingFile;
    }
}
