namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6EAB672EC97BB160, NameHash = 0x10D5ED9C9EE19797)]
    public class GcBaseDefenceStatusType : NMSTemplate
    {
        // size: 0x5
        public enum BaseDefenceStatusEnum {
            AttackingTarget,
            Alert,
            SearchingForTarget,
            Disabled,
            Security
        }
        /* 0x0 */ public BaseDefenceStatusEnum BaseDefenceStatus;
    }
}
