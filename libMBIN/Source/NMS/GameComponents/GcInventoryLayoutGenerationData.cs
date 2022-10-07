using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x82F3F18BB2C8F836, NameHash = 0x7AA76AD6E14A0C29)]
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
            UNKNOWN  // NOTE: The exe auto-extraction only seems to have 0x24 elements, but the total size indicates 0x25... No idea... will need to decompile to see...
        }
        [NMS(Size = 0x25, EnumType = typeof(GenerationDataPerSizeTypeEnum))]
        /* 0x0 */ public GcInventoryLayoutGenerationDataEntry[] GenerationDataPerSizeType;
    }
}
