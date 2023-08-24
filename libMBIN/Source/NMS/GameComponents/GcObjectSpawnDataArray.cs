using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x271FB012E97ECD60, NameHash = 0x3AAEFA9CCB9353C1)]
    public class GcObjectSpawnDataArray : NMSTemplate
    {
        /* 0x0 */ public GcTerrainTileType TileType;
        /* 0x4 */ public int MaxObjectsToSpawn;
        /* 0x8 */ public List<GcObjectSpawnData> Objects;
    }
}
