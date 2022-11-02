namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x22BF3123E9561313, NameHash = 0x7A4371C33E264E2C)]
    public class GcRewardMissionMessage : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 MessageID;
        /* 0x10 */ public bool BroadcastInMultiplayer;
    }
}
