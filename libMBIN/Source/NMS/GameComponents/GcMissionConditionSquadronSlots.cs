using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0xC, GUID = 0x5872BBCB944B5AD2, NameHash = 0xA1BAA7B81B1B5EF4)]
    public class GcMissionConditionSquadronSlots : NMSTemplate
    {
        /* 0x0 */ public int PilotSlots;
        /* 0x4 */ public bool OnlyCountFreeSlots;
        /* 0x8 */ public TkEqualityEnum Test;
    }
}
