using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x0BA8D3003D0FE5EB9)]
    public class GcAISpaceshipModelDataArray : NMSTemplate
    {
        public List<GcAISpaceshipModelData> Spaceships;
    }
}