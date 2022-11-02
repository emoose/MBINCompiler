using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x28B893BEBB5C91F0, NameHash = 0xB6094F57F9EFA01D)]
    public class GcUnlockableItemTreeNode : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Unlockable;
        /* 0x10 */ public List<GcUnlockableItemTreeNode> Children;
    }
}
