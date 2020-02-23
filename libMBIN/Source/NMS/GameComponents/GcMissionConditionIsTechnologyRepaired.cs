using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x63644C1513C9B8D3, NameHash = 0x24D022A0BCD713A0)]
    public class GcMissionConditionIsTechnologyRepaired : NMSTemplate
    {
        public GcTechnologyTableEnum Technology;
        public int RepairedComponents;
    }
}
