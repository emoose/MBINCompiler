using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xEFF94D33D5DB4E2B)]
    public class GcLeveledStatTable : NMSTemplate
    {
        public List<GcLeveledStatData> Table; // called GcLeveledStatTable in the exe
    }
}
