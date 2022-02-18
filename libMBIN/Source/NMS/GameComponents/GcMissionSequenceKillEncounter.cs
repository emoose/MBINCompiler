using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x120, GUID = 0xE33661217CE46088, NameHash = 0x07E1936B219E215F)]
    public class GcMissionSequenceKillEncounter : NMSTemplate
    {
        /* 0x00 */ public NMSString0x80 Message;
        /* 0x80 */ public NMSString0x20A EncounterComponentScanEvent;
        /* 0xA0 */ public NMSString0x80 DebugText;
    }
}
