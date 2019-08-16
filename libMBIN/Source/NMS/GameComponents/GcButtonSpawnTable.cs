using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x10, GUID = 0xDA4CA889E9A8A216)]
    public class GcButtonSpawnTable : NMSTemplate
    {
        public List<GcButtonSpawn> ButtonSpawns;
    }
}
