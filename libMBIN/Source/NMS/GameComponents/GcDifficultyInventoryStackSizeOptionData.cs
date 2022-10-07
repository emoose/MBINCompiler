namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAEBB19372EC94335, NameHash = 0xB9FD998A06AA6DE0)]
    public class GcDifficultyInventoryStackSizeOptionData : NMSTemplate
    {
        /* 0x00 */ public int SubstanceStackLimit;
        /* 0x04 */ public int ProductStackLimit;
        // size: 0xC
        public enum MaxSubstanceStackSizesEnum {
            Default,
            Personal,
            PersonalCargo,
            Ship,
            ShipCargo,
            Freighter,
            FreighterCargo,
            Vehicle,
            Chest,
            BaseCapsule,
            MaintenanceObject,
            UIPopup
        }
        [NMS(Size = 0xC, EnumType = typeof(MaxSubstanceStackSizesEnum))]
        /* 0x08 */ public int[] MaxSubstanceStackSizes;
        // size: 0xC
        public enum MaxProductStackSizesEnum {
            Default,
            Personal,
            PersonalCargo,
            Ship,
            ShipCargo,
            Freighter,
            FreighterCargo,
            Vehicle,
            Chest,
            BaseCapsule,
            MaintenanceObject,
            UIPopup
        }
        [NMS(Size = 0xC, EnumType = typeof(MaxProductStackSizesEnum))]
        /* 0x38 */ public int[] MaxProductStackSizes;
    }
}
