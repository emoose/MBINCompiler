using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4F82B53FA172F542, NameHash = 0xE7D049A3A9D077A8)]
    public class GcGeneratorUnitComponentData : NMSTemplate
    {
        // size: 0x3
        public enum GeneratorUnitTypeEnum {
            MiningUnit,
            GasHarvester,
            SystemHoover
        }
        /* 0x000 */ public GeneratorUnitTypeEnum GeneratorUnitType;
        /* 0x004 */ public int ResourceMaintenanceSlotOverride;
        // size: 0x10
        public enum BiomeGasRewardsEnum {
            Lush,
            Toxic,
            Scorched,
            Radioactive,
            Frozen,
            Barren,
            Dead,
            Weird,
            Red,
            Green,
            Blue,
            Test,
            Swamp,
            Lava,
            Waterworld,
            All
        }
        [NMS(Size = 0x10, EnumType = typeof(BiomeGasRewardsEnum))]
        /* 0x008 */ public NMSString0x10[] BiomeGasRewards;
        /* 0x110 */ public GcMaintenanceComponentData MaintenanceData;
    }
}
