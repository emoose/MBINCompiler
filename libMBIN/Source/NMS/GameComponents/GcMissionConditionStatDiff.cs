using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE7FB498200797448, NameHash = 0x4315517EE11B4860)]
    public class GcMissionConditionStatDiff : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 CurrentStat;
        /* 0x10 */ public NMSString0x10 TargetStat;
        /* 0x20 */ public int AmountPastTarget;
        /* 0x24 */ public TkEqualityEnum Test;
    }
}
