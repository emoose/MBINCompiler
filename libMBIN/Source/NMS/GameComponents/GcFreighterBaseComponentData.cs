using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x751FFC7E6E42C1E, NameHash = 0x7BA4A2BC)]
    public class GcFreighterBaseComponentData : NMSTemplate
    {
        [NMS(Index = 1, Size = 0x4, EnumType = typeof(GcInventoryClass.InventoryClassEnum))]
        /* 0x00 */ public GcFreighterBaseOptions[] FreighterBaseOptions;
        [NMS(Index = 2)]
        /* 0x40 */ public GcFilename FreighterBaseForPlayerReset;
        [NMS(Index = 3)]
        /* 0x50 */ public GcFilename WFCBuildingFile;
        // size: 0x2
        public enum FreighterBaseGenerationModeEnum : uint {
            Prefab,
            WFC,
        }
        [NMS(Index = 0)]
        /* 0x60 */ public FreighterBaseGenerationModeEnum FreighterBaseGenerationMode;
    }
}
