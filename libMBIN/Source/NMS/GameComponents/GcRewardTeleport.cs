namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x912145A89865A41E, NameHash = 0x9204A5F1450F4D7)]
    public class GcRewardTeleport : NMSTemplate
    {
        // size: 0x7
        public enum TeleportRewardTypeEnum {
            None,
            ToBase,
            Station0,
            Station1,
            Station2,
            Station3,
            Atlas,
        }
        /* 0x0 */ public TeleportRewardTypeEnum TeleportRewardType;
    }
}
