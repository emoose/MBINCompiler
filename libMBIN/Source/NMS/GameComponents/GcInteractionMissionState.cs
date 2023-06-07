namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2BCAB78BB7AE9437, NameHash = 0xBBC2C9E7EE1270B0)]
    public class GcInteractionMissionState : NMSTemplate
    {
        // size: 0x3
        public enum InteractionMissionStateEnum : uint {
            Unused,
            Unlocked,
            MonoCorrupted,
        }
        /* 0x0 */ public InteractionMissionStateEnum InteractionMissionState;
    }
}
