using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
    public class GcInventoryLayoutGenerationData : NMSTemplate     // size: 0x320
    {
        [NMS(Size = 0x19, EnumValue = new[] { "SciSmall", "SciMedium", "SciLarge", "FgtSmall", "FgtMedium", "FgtLarge", "ShtSmall", "ShtMedium", "ShtLarge", "DrpSmall", "DrpMedium", "DrpLarge",
                           "WeaponSmall", "WeaponMedium", "WeaponLarge", "FreighterSmall", "FreighterMedium", "FreighterLarge", "VehicleSmall", "VehicleMedium", "VehicleLarge",
                           "ChestSmall", "ChestMedium", "ChestLarge", "ChestCapsule"})]
        public GcInventoryLayoutGenerationDataEntry[] GenerationDataPerSizeType;
    }
}
