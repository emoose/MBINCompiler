namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x77E1DE4B42BE8BEB, NameHash = 0xD89FEDC2)]
    public class GcRewardMissionMessageToMatchingSeeds : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 MessageID;
        [NMS(Index = 1)]
        /* 0x10 */ public bool BroadcastInMultiplayer;
    }
}
