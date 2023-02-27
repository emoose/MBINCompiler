namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBB8DE87F79BFFCF0, NameHash = 0x60741FB7E840229E)]
    public class GcMissionSequenceBroadcastMessage : NMSTemplate
    {
        /* 0x00 */ public NMSString0x80 DebugText;
        /* 0x80 */ public NMSString0x10 MessageID;
        /* 0x90 */ public bool Seeded;
        /* 0x91 */ public bool SendToAllMatchingSeeds;
        /* 0x92 */ public bool Multiplayer;
        /* 0x93 */ public bool BroadcastToActiveMultiplayerMission;
    }
}
