namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3557950AA0C0BAE5, NameHash = 0xCFB91CCA40995CDC)]
    public class GcInventoryLayoutSizeType : NMSTemplate
    {
        // size: 0x28
        public enum SizeTypeEnum : uint {
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
            RobotSmall,
            RobotMedium,
            RobotLarge,
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
            RocketLocker,
        }
        /* 0x0 */ public SizeTypeEnum SizeType;
    }
}
