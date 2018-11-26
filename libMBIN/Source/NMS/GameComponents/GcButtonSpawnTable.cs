using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x10, GUID = 0x53A21967B8EFF6FB)]
    public class GcButtonSpawnTable : NMSTemplate
    {
        public List<GcButtonSpawn> ButtonSpawns;
    }
}
