using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB3B6D25E12E7E323, NameHash = 0xE07E83B8A167074C)]
    public class GcStatGroupTable : NMSTemplate
    {
        /* 0x0 */ public List<GcStatGroupData> StatGroupTable;
    }
}
