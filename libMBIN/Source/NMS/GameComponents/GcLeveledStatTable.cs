using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x0EFF94D33D5DB4E2B)]
    public class GcLeveledStatTable : NMSTemplate
    {
        public List<GcLeveledStatData> Table; // called GcLeveledStatTable in the exe
    }
}
