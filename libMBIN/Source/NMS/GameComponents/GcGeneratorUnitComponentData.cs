using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x320, GUID = 0xE00FD71EA06ABA75, NameHash = 0xE7D049A3A9D077A8)]
    public class GcGeneratorUnitComponentData : NMSTemplate
    {
		public enum GeneratorUnitTypeEnum { MiningUnit, GasHarvester }
		public GeneratorUnitTypeEnum GeneratorUnitType;
        /* 0x04 */ public int ResourceMaintenanceSlotOverride;
        [NMS(Size = 0xD, EnumType = typeof(GcBiomeType.BiomeEnum))]
        /* 0x08 */ public NMSString0x10[] BiomeGasRewards;
        [NMS(Size = 0x8, Ignore = true)]
        /* 0xD8 */ public byte[] PaddingA8;
        /* 0xE0 */ public GcMaintenanceComponentData MaintenanceData;
    }
}
