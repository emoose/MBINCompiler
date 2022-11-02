using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDC379BFBE7C52DA9, NameHash = 0xB764F802BDE36ADF)]
    public class GcByteBeatTemplate : NMSTemplate
    {
        /* 0x00 */ public float Weight;
        /* 0x04 */ public GcByteBeatToken TokenType;
        /* 0x08 */ public int MinValue;
        /* 0x0C */ public int MaxValue;
        /* 0x10 */ public List<GcByteBeatTemplate> Children;
    }
}
