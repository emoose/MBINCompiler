using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x88124B83B6861EAC)]
    public class GcButtonSpawnTable : NMSTemplate        // size: 0x10
    {
        public List<GcButtonSpawn> ButtonSpawns;
    }
}
