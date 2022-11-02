using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC8F033CF245727D6, NameHash = 0x56711152687FE3A9)]
    public class GcMissionConditionItemCostsEnabled : NMSTemplate
    {
        /* 0x0 */ public GcItemNeedPurpose Purpose;
        /* 0x4 */ public bool Enabled;
    }
}
