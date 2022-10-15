using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1BE70545A3D6ACF, NameHash = 0x7AA76AD6E14A0C29)]
    public class GcInventoryLayoutGenerationData : NMSTemplate
    {
        // size: 0x25
        public enum GenerationDataPerSizeTypeEnum {
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
        [NMS(Size = 0x25, EnumType = typeof(GenerationDataPerSizeTypeEnum))]
        /* 0x0 */ public GcInventoryLayoutGenerationDataEntry[] GenerationDataPerSizeType;
    }
}
