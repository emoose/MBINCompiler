namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4FAE8CB924972158, NameHash = 0x68945B9C7D77B53)]
    public class GcSentinelResource : NMSTemplate
    {
        /* 0x00 */ public NMSString0x80 Resource;
        /* 0x80 */ public int BaseHealth;
        /* 0x84 */ public int HealthIncreasePerLevel;
        /* 0x88 */ public float RepairTime;
        /* 0x8C */ public float RepairThreshold;
        /* 0x90 */ public float Scale;
    }
}
