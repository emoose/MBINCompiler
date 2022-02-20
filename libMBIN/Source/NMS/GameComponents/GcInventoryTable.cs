using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x900, GUID = 0xFD7370FC56486179, NameHash = 0x32822FA2FD268A65)]
    public class GcInventoryTable : NMSTemplate
    {
        /* 0x000 */ public List<GcInventoryTableEntry> Table;
        /* 0x010 */ public GcInventoryLayoutGenerationData GenerationData;
        /* 0x200 */ public GcInventoryCostData ShipCostData;
        [NMS(Size = 0x5, EnumType = typeof(GcWeaponClasses.WeaponStatClassEnum))]
        /* 0x340 */ public GcInventoryCostDataEntry[] WeaponCostData;
        /* 0x408 */ public GcInventoryCostDataEntry VehicleCostData;
        [NMS(Size = 0x3, EnumType = typeof(GcWealthClass.WealthClassEnum))]
        /* 0x408 */ public GcInventoryClassProbabilities[] ClassProbabilityData;
        /* 0x460 */ public GcInventoryGenerationBaseStatData VehicleBaseStatsData;
        [NMS(Size = 0x8, EnumType = typeof(GcSpaceshipClasses.ShipClassEnum))]
        /* 0x4A0 */ public GcInventoryGenerationBaseStatData[] ShipBaseStatsData;
        [NMS(Size = 0x5, EnumType = typeof(GcWeaponClasses.WeaponStatClassEnum))]
        /* 0x6A0 */ public GcInventoryGenerationBaseStatData[] WeaponBaseStatsData;
        /* 0x7E0 */ public List<GcInventoryBaseStat> BaseStats;
        [NMS(Size = 0x8, EnumType = typeof(GcSpaceshipClasses.ShipClassEnum))]
        /* 0x7F0 */ public GcShipInventoryMaxUpgradeCapacity[] ShipInventoryMaxUpgradeSize;
        /* 0x8F0 */ public GcWeaponInventoryMaxUpgradeCapacity WeaponInventoryMaxUpgradeSize;
    }
}
