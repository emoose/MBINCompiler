namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5988468BEE72BE66, NameHash = 0x33060745)]
    public class GcInventoryLayoutSizeType : NMSTemplate
    {
        // size: 0x2D
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
            FishBaitBox,
            FishingPlatform,
            FoodUnit,
            Corvette,
            CorvetteStorage,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public SizeTypeEnum SizeType;
    }
}
