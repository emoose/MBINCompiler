namespace libMBIN.Models.Structs
{
    public class GcGeneratorUnitComponentData : NMSTemplate     // size: 0x1A0
    {
        public int GeneratorUnitType;
        /* 0x00 */ public string[] GeneratorUnitTypeValues()
        {
            return new[] { "MiningUnit", "GasHarvester" };
        }
        /* 0x04 */ public int ResourceMaintenanceSlotOverride;
        [NMS(Size = 0xA)]
        /* 0x08 */ public NMSString0x10[] BiomeGasRewards;
        [NMS(Size = 0x8, Ignore = true)]
        /* 0xA8 */ public byte[] PaddingA8;
        /* 0xB0 */ public GcMaintenanceComponentData MaintenanceData;
    }
}
