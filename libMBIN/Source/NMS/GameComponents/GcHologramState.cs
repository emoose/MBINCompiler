namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4E078F4756530241, NameHash = 0xBA2B6A2A)]
    public class GcHologramState : NMSTemplate
    {
        // size: 0x4
        public enum HologramStateEnum : uint {
            Hologram,
            Attract,
            Explode,
            Disabled,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public HologramStateEnum HologramState;
    }
}
