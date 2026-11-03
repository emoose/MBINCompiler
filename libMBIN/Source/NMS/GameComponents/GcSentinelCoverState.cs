namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6EC06CCD804BFA60, NameHash = 0xE1645A55)]
    public class GcSentinelCoverState : NMSTemplate
    {
        // size: 0x4
        public enum SentinelCoverStateEnum : uint {
            Deploying,
            Deployed,
            ShuttingDown,
            ShutDown,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public SentinelCoverStateEnum SentinelCoverState;
    }
}
