using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC9FFFC7A5A173EEC, NameHash = 0x81D792A0622C83B1)]
    public class GcMissionConditionFrigateCount : NMSTemplate
    {
        /* 0x0 */ public int FrigateCount;
        /* 0x4 */ public TkEqualityEnum Test;
    }
}
