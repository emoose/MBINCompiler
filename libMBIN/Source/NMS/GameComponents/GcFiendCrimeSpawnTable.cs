using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDA58EABD3E554BF3, NameHash = 0x4EBB7BDC5EE300EA)]
    public class GcFiendCrimeSpawnTable : NMSTemplate
    {
        /* 0x0 */ public GcFiendCrime Crime;
        /* 0x4 */ public float ResponseRate;
        /* 0x8 */ public List<GcFiendCrimeSpawnData> Spawns;
    }
}
