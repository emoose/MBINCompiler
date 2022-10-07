using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEE43876427F39D95, NameHash = 0x7A13912B545C6365)]
    public class GcInventoryGenerationBaseStatData : NMSTemplate
    {
        // size: 0x4
        public enum BaseStatsPerClassEnum {
            C,
            B,
            A,
            S
        }
        [NMS(Size = 0x4, EnumType = typeof(BaseStatsPerClassEnum))]
        /* 0x0 */ public GcInventoryGenerationBaseStatClassData[] BaseStatsPerClass;
    }
}
