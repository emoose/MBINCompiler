using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x50, GUID = 0x3B5F72E90BD1D033, NameHash = 0x785665CB6C017B4C)]
    public class GcAISpaceshipManagerData : NMSTemplate
    {
        [NMS(Size = 5, EnumType = typeof(GcRealityCommonFactions.AIFactionEnum))]
        public GcAISpaceshipModelDataArray[] SystemSpaceships;
    }
}
