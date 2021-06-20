using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x350, GUID = 0xE00FD71EA06ABA75, NameHash = 0xE7D049A3A9D077A8)]
    public class GcGeneratorUnitComponentData : NMSTemplate
    {
		public enum GeneratorUnitTypeEnum { MiningUnit, GasHarvester }
		/* 0x000 */ public GeneratorUnitTypeEnum GeneratorUnitType;
        /* 0x004 */ public int ResourceMaintenanceSlotOverride;
        [NMS(Size = 0x10, EnumType = typeof(GcBiomeType.BiomeEnum))]
        /* 0x008 */ public NMSString0x10[] BiomeGasRewards;
        /* 0x110 */ public GcMaintenanceComponentData MaintenanceData;
    }
}
