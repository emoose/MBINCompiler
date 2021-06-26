using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x10, GUID = 0xD0FEA5AB3853E69, NameHash = 0xFECA26D94DE68300)]
    public class GcButtonSpawnTable : NMSTemplate
    {
        public List<GcButtonSpawn> ButtonSpawns;
    }
}
