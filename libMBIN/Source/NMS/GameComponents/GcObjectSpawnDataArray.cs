using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x18, GUID = 0xC751CC4D241539F7, NameHash = 0x3AAEFA9CCB9353C1)]
    public class GcObjectSpawnDataArray : NMSTemplate
    {
        /* 0x0 */ public GcTerrainTileType TileType;
        /* 0x4 */ public int MaxObjectsToSpawn;
        /* 0x8 */ public List<GcObjectSpawnData> Objects;
    }
}
