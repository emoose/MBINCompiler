using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x5E1C192BBFA383BA, SubGUID = 0x7169FE9CB058F962)]
    public class GcLeveledStatTable : NMSTemplate
    {
        public List<GcLeveledStatData> Table;
    }
}
