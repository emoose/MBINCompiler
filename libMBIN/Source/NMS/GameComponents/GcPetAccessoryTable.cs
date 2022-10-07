using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBE4EB06F81A126A1, NameHash = 0x9ED3D0A38623AF53)]
    public class GcPetAccessoryTable : NMSTemplate
    {
        // size: 0x1B
        public enum AccessoriesEnum {
            None,
            CargoCylinder,
            Containers,
            ShieldArmour,
            SolarBattery,
            Tank,
            WingPanel,
            TravelPack,
            SpacePack,
            CargoLong,
            Antennae,
            Computer,
            Toolbelt,
            LeftCanisters,
            LeftEnergyCoil,
            LeftFrigateTurret,
            LeftHeadLights,
            LeftArmourPlate,
            LeftTurret,
            LeftSupportSystem,
            RightCanisters,
            RightEnergyCoil,
            RightFrigateTurret,
            RightHeadLights,
            RightArmourPlate,
            RightTurret,
            RightSupportSystem
        }
        [NMS(Size = 0x1B, EnumType = typeof(AccessoriesEnum))]
        /* 0x000 */ public GcPetAccessoryInfo[] Accessories;
        /* 0x360 */ public List<GcPetAccessoryGroup> AccessoryGroups;
    }
}
