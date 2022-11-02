using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x181F35B9DCAFC278, NameHash = 0x77F73B95EA71A04C)]
    public class GcCostFleetStoredIncome : NMSTemplate
    {
        /* 0x0 */ public GcFrigateClass Class;
        /* 0x4 */ public int RequiredAmount;
    }
}
