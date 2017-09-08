using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
    [NMS(Size = 0x18)]
    public class GcObjectSpawnDataArray : NMSTemplate
    {
        public GcTerrainTileType TileType;
        public int MaxObjectsToSpawn;
        public List<GcObjectSpawnData> ObjectData;
    }
}
