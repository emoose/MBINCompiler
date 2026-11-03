namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9DDCF95AFA20F513, NameHash = 0xE266721D)]
    public class GcRewardMissionMessage : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 MessageID;
        [NMS(Index = 1)]
        /* 0x10 */ public bool BroadcastInMultiplayer;
    }
}
