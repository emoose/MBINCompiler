using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    public class GcInventoryTable : NMSTemplate     // size: 0x6F0
    {
        /* 0x000 */ public List<GcInventoryTableEntry> Table;
        /* 0x010 */ public GcInventoryLayoutGenerationData GenerationData;
        /* 0x1D0 */ public GcInventoryCostData ShipCostData;
        [NMS(Size = 0x4, EnumValue = new[] { "Pistol", "Rifle", "Pristine", "Alien" })]
        /* 0x2E8 */ public GcInventoryCostDataEntry[] WeaponCostData;
        /* 0x388 */ public GcInventoryCostDataEntry VehicleCostData;
        [NMS(Size = 0x3, EnumValue = new[] { "Gek_System", "Vykeen_System", "Korvax_System" })]
        /* 0x3B0 */ public GcInventoryClassProbabilities[] ClassProbabilityData;
        /* 0x3E0 */ public GcInventoryGenerationBaseStatData VehicleBaseStatsData;
        [NMS(Size = 0x7, EnumValue = new[] { "Freighter", "Dropship", "Fighter", "Scientific", "Shuttle", "PlayerFreighter", "Royal" })]
        /* 0x420 */ public GcInventoryGenerationBaseStatData[] ShipBaseStatsData;
        [NMS(Size = 0x4, EnumValue = new[] { "Pistol", "Rifle", "Pristine", "Alien" })]
        /* 0x5E0 */ public GcInventoryGenerationBaseStatData[] WeaponBaseStatsData;
        /* 0x6E0 */ public List<GcInventoryBaseStat> BaseStats;
    }
}
