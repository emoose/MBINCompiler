using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3B1F10D65FD0D030, NameHash = 0x63D04F17E4BE7335)]
    public class GcMaintenanceGroupEntry : NMSTemplate
    {
        /* 0x00 */ public GcInventoryType Type;
        /* 0x08 */ public NMSString0x10 Id;
        /* 0x18 */ public float ProbabilityWeighting;
        /* 0x1C */ public float OverrideAmount;
    }
}
