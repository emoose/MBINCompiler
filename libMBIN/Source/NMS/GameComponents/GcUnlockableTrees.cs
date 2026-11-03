using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x96FB595A8D8BD6C8, NameHash = 0x600392A1)]
    public class GcUnlockableTrees : NMSTemplate
    {
        [NMS(Index = 0, Size = 0xF, EnumType = typeof(GcUnlockableItemTreeGroups.UnlockableItemTreeEnum))]
        /* 0x000 */ public GcUnlockableItemTrees[] Trees;
        [NMS(Index = 1)]
        /* 0x2D0 */ public List<GcUnlockableTreeCostType> CostTypes;
    }
}
