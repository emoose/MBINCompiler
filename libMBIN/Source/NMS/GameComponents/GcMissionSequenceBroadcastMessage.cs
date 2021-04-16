using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x98, GUID = 0x55D63D29EEF5CE11, NameHash = 0x60741FB7E840229E)]
    public class GcMissionSequenceBroadcastMessage : NMSTemplate
    {
        [NMS(Size = 0x80)]
        /* 0x00 */ public string DebugText;
        [NMS(Size = 0x10)]
        /* 0x80 */ public string MessageID;
        /* 0x90 */ public bool Seeded;
        /* 0x91 */ public bool SendToAllMatchingSeeds;
        /* 0x92 */ public bool Multiplayer;
        /* 0x93 */ public bool BroadcastToActiveMultiplayerMission;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x94 */ public byte[] EndPadding;
    }
}
