using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1A2C26901584AFBA, NameHash = 0x6FDD00442DB9926C)]
    public class GcCostNPCHabitation : NMSTemplate
    {
        /* 0x0 */ public GcNPCHabitationType NPCHabitationType;
        /* 0x4 */ public bool MustBeInhabited;
    }
}
