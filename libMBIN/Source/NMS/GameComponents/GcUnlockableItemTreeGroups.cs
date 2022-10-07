namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x24370E169189B2D6, NameHash = 0x8F55B25E91A470A9)]
    public class GcUnlockableItemTreeGroups : NMSTemplate
    {
        // size: 0xE
        public enum UnlockableItemTreeEnum {
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
        /* 0x0 */ public UnlockableItemTreeEnum UnlockableItemTree;
    }
}
