using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF052E979247D7E39, NameHash = 0x77F73B95EA71A04C)]
    public class GcCostFleetStoredIncome : NMSTemplate
    {
        /* 0x0 */ public GcFrigateClass Class;
        /* 0x4 */ public int RequiredAmount;
    }
}
