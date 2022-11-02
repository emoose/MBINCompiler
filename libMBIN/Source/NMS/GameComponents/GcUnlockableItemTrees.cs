using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9EF4C2601B969D79, NameHash = 0x2B87D92751133C6D)]
    public class GcUnlockableItemTrees : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20A Title;
        /* 0x20 */ public List<GcUnlockableItemTree> Trees;
    }
}
