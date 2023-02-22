using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA2D2D3EA49B134CF, NameHash = 0xFECA26D94DE68300)]
    public class GcButtonSpawnTable : NMSTemplate
    {
        /* 0x0 */ public List<GcButtonSpawn> ButtonSpawns;
    }
}
