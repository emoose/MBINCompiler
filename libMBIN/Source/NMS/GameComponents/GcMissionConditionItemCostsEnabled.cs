using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8A32068550A11357, NameHash = 0xF7D2DC59)]
    public class GcMissionConditionItemCostsEnabled : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public GcItemNeedPurpose Purpose;
        [NMS(Index = 1)]
        /* 0x4 */ public bool Enabled;
    }
}
