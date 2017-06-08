using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
    public class GcInventoryTable : NMSTemplate     // size: 0x7C8
    {
        /* 0x000 */ public List<GcInventoryTableEntry> Table;
        /* 0x010 */ public GcInventoryLayoutGenerationData GenerationData;
        /* 0x330 */ public GcInventoryCostData ShipCostData;
        [NMS(Size = 0x4, EnumValue = new[] { "Pistol", "Rifle", "Pristine", "Alien" })]
        /* 0x420 */ public GcInventoryCostDataEntry[] WeaponCostData;
        /* 0x4C0 */ public GcInventoryCostDataEntry VehicleCostData;
        [NMS(Size = 0x4, EnumValue = new[] { "C", "B", "A", "S" })]
        /* 0x4E8 */ public float[] ClassProbabilities;
        /* 0x4F8 */ public GcInventoryGenerationBaseStatData VehicleBaseStatsData;
        [NMS(Size = 0x6, EnumValue = new[] { "Freighter", "Dropship", "Fighter", "Scientific", "Shuttle", "PlayerFreighter" })]
        /* 0x538 */ public GcInventoryGenerationBaseStatData[] ShipBaseStatsData;
        [NMS(Size = 0x4, EnumValue = new[] { "Pistol", "Rifle", "Pristine", "Alien" })]
        /* 0x6B8 */ public GcInventoryGenerationBaseStatData[] WeaponBaseStatsData;
        /* 0x7B8 */ public List<GcInventoryBaseStat> BaseStats;
    }
}
