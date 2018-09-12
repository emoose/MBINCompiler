using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x4C36609963787EB4)]
    public class GcNPCHabitationType : NMSTemplate
    {
		public enum NPCHabitationTypeEnum { WeaponsExpert, Farmer, Builder, Vehicles, Scientist }
		public NPCHabitationTypeEnum NPCHabitationType;
    }
}
