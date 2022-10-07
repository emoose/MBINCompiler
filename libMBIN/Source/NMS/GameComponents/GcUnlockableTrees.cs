using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE774D1646AC91EF2, NameHash = 0xDDC3AC505BDF81E2)]
    public class GcUnlockableTrees : NMSTemplate
    {
        // size: 0xE
        public enum TreesEnum {
            Test,
            BasicBaseParts,
            BasicTechParts,
            BaseParts,
            SpecialBaseParts,
            SuitTech,
            ShipTech,
            WeapTech,
            ExocraftTech,
            CraftProducts,
            FreighterTech,
            S9BaseParts,
            S9ExoTech,
            S9ShipTech
        }
        [NMS(Size = 0xE, EnumType = typeof(TreesEnum))]
        /* 0x000 */ public GcUnlockableItemTrees[] Trees;
        /* 0x2A0 */ public List<GcUnlockableTreeCostType> CostTypes;
    }
}
