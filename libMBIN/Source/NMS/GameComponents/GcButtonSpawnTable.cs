using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA78055D6787A9C56, NameHash = 0xFECA26D94DE68300)]
    public class GcButtonSpawnTable : NMSTemplate
    {
        /* 0x0 */ public List<GcButtonSpawn> ButtonSpawns;
    }
}
