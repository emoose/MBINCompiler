namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x95EA3BF7ED3E2EAB, NameHash = 0xFACED760)]
    public class GcNetworkInterpolationComponentData : NMSTemplate
    {
        // size: 0x3
        public enum SynchroniseScaleEnum : uint {
            Never,
            Once,
            Always,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public SynchroniseScaleEnum SynchroniseScale;
        [NMS(Index = 1)]
        /* 0x4 */ public bool SupportTeleportation;
        [NMS(Index = 2)]
        /* 0x5 */ public bool UpdateWhileInactive;
    }
}
