using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x300, GUID = 0x544CC9937C378016)]
    public class GcAISpaceshipMappingData : NMSTemplate
    {
        [NMS(Size = 0x6, EnumValue = new string[] { "Standard", "Freighter", "CapitalFreighter", "SmallFreighter", "TinyFreighter", "Frigate" })]
        public GcAISpaceshipInstanceData[] ClassMap;
    }
}
