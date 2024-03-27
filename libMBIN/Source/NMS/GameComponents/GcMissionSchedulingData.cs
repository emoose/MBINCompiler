using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x28AEB8E606F98613, NameHash = 0xC7D1E140B3A1C6B2)]
    public class GcMissionSchedulingData : NMSTemplate
    {
        /* 0x00 */ public NMSTemplate RecurrenceType;
        /* 0x50 */ public GcDate StartDate;
        /* 0x64 */ public GcDate EndDate;
        /* 0x78 */ public bool IndependentStart;
        /* 0x79 */ public bool HasEndDate;
        /* 0x80 */ public ulong EarlyEndOffset;
        /* 0x88 */ public List<NMSString0x10> MissionIDs;
    }
}
