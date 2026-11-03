namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE90CF92E1294C3D8, NameHash = 0x3C426079)]
    public class GcRewardTeleport : NMSTemplate
    {
        // size: 0x5
        public enum TeleportRewardTypeEnum : uint {
            None,
            ToBase,
            Station,
            Atlas,
            WeirdPortalWarp,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public TeleportRewardTypeEnum TeleportRewardType;
    }
}
