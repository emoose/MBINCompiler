namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF4171603FA4303CD, NameHash = 0x7A4371C33E264E2C)]
    public class GcRewardMissionMessage : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 MessageID;
        /* 0x10 */ public bool BroadcastInMultiplayer;
    }
}
