using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x0BA8D3003D0FE5EB9)]
    public class GcAISpaceshipModelDataArray : NMSTemplate
    {
        public List<GcAISpaceshipModelData> Spaceships;
    }
}