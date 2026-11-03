using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x37D55099B13B9F9C, NameHash = 0x58F2CAEC)]
    public class GcCreatureDataTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcCreatureData> Table;
    }
}
