using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
	[NMS(Size = 0x18, GUID = 0x0BC0EE957E29F834C)]
    public class GcObjectSpawnDataArray : NMSTemplate
    {
        public GcTerrainTileType TileType;
        public int MaxObjectsToSpawn;
        public List<GcObjectSpawnData> ObjectData;
    }
}
