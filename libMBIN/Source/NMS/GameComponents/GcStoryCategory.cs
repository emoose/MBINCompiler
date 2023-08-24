using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xED87706CBFE6F59A, NameHash = 0x276FB03774F36C9F)]
    public class GcStoryCategory : NMSTemplate
    {
        /* 0x000 */ public NMSString0x20A CategoryID;
        /* 0x020 */ public NMSString0x20A CategoryIDUpper;
        /* 0x040 */ public TkTextureResource IconOn;
        /* 0x0C4 */ public TkTextureResource IconOff;
        /* 0x148 */ public List<GcStoryPage> Pages;
    }
}
