using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xCBA9292BC38B748F, NameHash = 0x24D022A0BCD713A0)]
    public class GcMissionConditionIsTechnologyRepaired : NMSTemplate
    {
        public GcTechnologyTableEnum Technology;
        public int RepairedComponents;
    }
}
