using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x374213750797CD00, NameHash = 0x7169FE9CB058F962)]
    public class GcLeveledStatTable : NMSTemplate
    {
        /* 0x0 */ public List<GcLeveledStatData> LeveledStatTable;
    }
}
