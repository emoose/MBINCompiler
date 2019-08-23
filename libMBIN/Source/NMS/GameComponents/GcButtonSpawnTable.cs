using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x10, GUID = 0x1C47DED1D3AC2C96, SubGUID = 0xFECA26D94DE68300)]
    public class GcButtonSpawnTable : NMSTemplate
    {
        public List<GcButtonSpawn> ButtonSpawns;
    }
}
