namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA7C2C7997436B9E6, NameHash = 0xBBC2C9E7EE1270B0)]
    public class GcInteractionMissionState : NMSTemplate
    {
        // size: 0x2
        public enum InteractionMissionStateEnum : uint {
            Unused,
            Unlocked,
        }
        /* 0x0 */ public InteractionMissionStateEnum InteractionMissionState;
    }
}
