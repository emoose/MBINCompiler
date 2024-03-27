using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1648D4C0A36198B8, NameHash = 0x5CF9A5D0C4877494)]
    public class GcSentinelSpawnWave : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Id;
        /* 0x10 */ public List<GcSentinelSpawnData> Spawns;
        /* 0x20 */ public int ReinforceAt;
    }
}
