namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x22072DF17EC2DAE, NameHash = 0x9AFBFA1C253ADF63)]
    public class GcSentinelCoverState : NMSTemplate
    {
        // size: 0x4
        public enum SentinelCoverStateEnum {
            Deploying,
            Deployed,
            ShuttingDown,
            ShutDown,
        }
        /* 0x0 */ public SentinelCoverStateEnum SentinelCoverState;
    }
}
