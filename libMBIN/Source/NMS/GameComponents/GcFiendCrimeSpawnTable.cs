using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF11ACFCECBC95ACF, NameHash = 0x4EBB7BDC5EE300EA)]
    public class GcFiendCrimeSpawnTable : NMSTemplate
    {
        /* 0x0 */ public GcFiendCrime Crime;
        /* 0x4 */ public float ResponseRate;
        /* 0x8 */ public List<GcFiendCrimeSpawnData> Spawns;
    }
}
