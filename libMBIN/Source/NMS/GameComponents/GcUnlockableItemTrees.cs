using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7427D4FE1C1DF652, NameHash = 0x2B87D92751133C6D)]
    public class GcUnlockableItemTrees : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20A Title;
        /* 0x20 */ public List<GcUnlockableItemTree> Trees;
    }
}
