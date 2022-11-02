using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x54ECD7487D358670, NameHash = 0x37476C35069E0A8F)]
    public class GcGeneratedBasePruningRule : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 RuleId;
        /* 0x10 */ public NMSString0x10 NodeName;
        /* 0x20 */ public int MaxPerRoom;
        /* 0x24 */ public int MaxPerDungeon;
        /* 0x28 */ public List<NMSString0x10> RoomFilters;
    }
}
