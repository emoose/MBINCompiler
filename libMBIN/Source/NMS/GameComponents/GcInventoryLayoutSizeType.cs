using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x4, GUID = 0xC84CE79CC0FE81EE, NameHash = 0xCFB91CCA40995CDC)]
    public class GcInventoryLayoutSizeType : NMSTemplate
    {
		public enum SizeTypeEnum {
            SciSmall, SciMedium, SciLarge, FgtSmall, FgtMedium, FgtLarge, ShuSmall, ShtMedium, ShtLarge, DrpSmall,
            DrpMedium, DrpLarge, RoySmall, RoyMedium, RoyLarge, AlienSmall, AlienMedium, AlienLarge, WeaponSmall, WeaponMedium,
            WeaponLarge, FreighterSmall, FreighterMedium, FreighterLarge, VehicleSmall, VehicleMedium, VehicleLarge, ChestSmall, ChestMedium, ChestLarge,
            ChestCapsule
        }
		public SizeTypeEnum SizeType;
    }
}