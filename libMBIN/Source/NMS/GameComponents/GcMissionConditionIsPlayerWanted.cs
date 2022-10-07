using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x94BE14A6488F8913, NameHash = 0x470EE61C4698CBB9)]
    public class GcMissionConditionIsPlayerWanted : NMSTemplate
    {
        /* 0x0 */ public int Level;
        /* 0x4 */ public TkEqualityEnum Test;
    }
}
