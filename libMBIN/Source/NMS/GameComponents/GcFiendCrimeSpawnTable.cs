using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x18, GUID = 0xA9762B2E1BF5B438, NameHash = 0x4EBB7BDC5EE300EA)]
    public class GcFiendCrimeSpawnTable : NMSTemplate
    {
        public GcFiendCrime Crime;
        public float ResponseRate;
        public List<GcFiendCrimeSpawnData> Spawns;
    }
}
