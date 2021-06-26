using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x8, GUID = 0x3E3746301EA071B3, NameHash = 0x6FDD00442DB9926C)]
    public class GcCostNPCHabitation : NMSTemplate
    {
        public GcNPCHabitationType NPCHabitationType;
        public bool MustBeInhabited;
    }
}