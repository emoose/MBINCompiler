using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE3A7CC493BC6B3E7, NameHash = 0xFECA26D94DE68300)]
    public class GcButtonSpawnTable : NMSTemplate
    {
        /* 0x0 */ public List<GcButtonSpawn> ButtonSpawns;
    }
}
