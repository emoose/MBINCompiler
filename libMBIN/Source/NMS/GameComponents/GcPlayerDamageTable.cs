using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x0BE059F15C774CD3F)]
    public class GcPlayerDamageTable : NMSTemplate
    {
        public List<GcPlayerDamageData> DamageTable;
    }
}
