namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC7F6E614A718A5EC, NameHash = 0xCFB91CCA40995CDC)]
    public class GcInventoryLayoutSizeType : NMSTemplate
    {
        // size: 0x25
        public enum SizeTypeEnum {
            SciSmall,
            SciMedium,
            SciLarge,
            FgtSmall,
            FgtMedium,
            FgtLarge,
            ShuSmall,
            ShtMedium,
            ShtLarge,
            DrpSmall,
            DrpMedium,
            DrpLarge,
            RoySmall,
            RoyMedium,
            RoyLarge,
            AlienSmall,
            AlienMedium,
            AlienLarge,
            SailSmall,
            SailMedium,
            SailLarge,
            WeaponSmall,
            WeaponMedium,
            WeaponLarge,
            FreighterSmall,
            FreighterMedium,
            FreighterLarge,
            VehicleSmall,
            VehicleMedium,
            VehicleLarge,
            ChestSmall,
            ChestMedium,
            ChestLarge,
            ChestCapsule,
            Suit,
            MaintObject,
            RocketLocker
        }
        /* 0x0 */ public SizeTypeEnum SizeType;
    }
}
