using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x2A0, GUID = 0x0000000000000000, NameHash = 0x245D62E60DEB8B1E)]
    public class GcMissionSequenceCreateSpecificPulseEncounter : NMSTemplate
    {
        [NMS(Size = 0x80)]
        /* 0x000 */ public string Message;
        [NMS(Size = 0x80)]
        /* 0x080 */ public string MessageNoShip;
        [NMS(Size = 0x80)]
        /* 0x100 */ public string MessageNotPulsing;
        [NMS(Size = 0x80)]
        /* 0x180 */ public string MessageSignalBlocked;
        /* 0x200 */ public float MinTimeInPulse;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x204 */ public byte[] Padding204;
        [NMS(Size = 0x10)]
        /* 0x208 */ public string PulseEncounterID;
        /* 0x218 */ public bool AllowAnyEncounter;
        /* 0x219 */ public bool Silent;
        [NMS(Size = 0x80)]
        /* 0x21A */ public string DebugText;
        [NMS(Size = 0x6, Ignore = true)]
        /* 0x29A */ public byte[] EndPadding;
    }
}
