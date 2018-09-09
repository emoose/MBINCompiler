using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x7A792008B203503F)]
    public class GcAISpaceshipPreloadList : NMSTemplate
    {
        public GcRealityCommonFactions Faction;
        [NMS(Size = 4, Ignore = true)]
        public byte[] Padding4;

        public List<GcAISpaceshipPreloadCacheData> Cache;
    }
}
