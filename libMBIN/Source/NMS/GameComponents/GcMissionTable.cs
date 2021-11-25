using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x10, GUID = 0xF24AC40ADC5F0238, NameHash = 0x26335C55292A7766)]
    public class GcMissionTable : NMSTemplate
    {
        /* 0x0 */ public List<GcGenericMissionSequence> Missions;
    }
}
