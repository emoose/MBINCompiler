namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD19A2E040F8046A2, NameHash = 0xB47279F1694E0681)]
    public class GcPetAccessoryType : NMSTemplate
    {
        // size: 0x1B
        public enum PetAccessoryEnum : uint {
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
            RightSupportSystem,
        }
        /* 0x0 */ public PetAccessoryEnum PetAccessory;
    }
}
