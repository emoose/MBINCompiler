using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x593BAA97DD3FF704, NameHash = 0x6D2F8C8D)]
    public class GcGameTableDiceConfigData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x20A Id;
        [NMS(Index = 1)]
        /* 0x20 */ public List<GcGameTableDiceConfigFaceData> Faces;
    }
}
