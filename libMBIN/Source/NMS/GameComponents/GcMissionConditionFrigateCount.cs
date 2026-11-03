using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x86B417D4F6E26621, NameHash = 0x237DDDA)]
    public class GcMissionConditionFrigateCount : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public int FrigateCount;
        [NMS(Index = 1)]
        /* 0x4 */ public TkEqualityEnum Test;
    }
}
