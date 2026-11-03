namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCF1A2FC68F229A01, NameHash = 0x7938FDDB)]
    public class GcInteractionMissionState : NMSTemplate
    {
        // size: 0x4
        public enum InteractionMissionStateEnum : uint {
            Unused,
            Unlocked,
            MonoCorrupted,
            GiftGiven,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public InteractionMissionStateEnum InteractionMissionState;
    }
}
