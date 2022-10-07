namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE3FCFF5B621FA649, NameHash = 0x51FB1B6785B647F2)]
    public class GcRewardShipAssistance : NMSTemplate
    {
        // size: 0x2
        public enum AssistanceTypeEnum {
            Police,
            Wingmen
        }
        /* 0x0 */ public AssistanceTypeEnum AssistanceType;
        /* 0x4 */ public float Time;
    }
}
