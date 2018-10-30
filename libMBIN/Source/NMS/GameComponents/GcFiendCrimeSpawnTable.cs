using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x18, GUID = 0x84B37C7D40A145B2)]
    public class GcFiendCrimeSpawnTable : NMSTemplate
    {
        public GcFiendCrime Crime;
        public float ResponseRate;
        public List<GcFiendCrimeSpawnData> Spawns;
    }
}
