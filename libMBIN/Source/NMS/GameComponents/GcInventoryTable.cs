using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x47A2A1F2323F3A0B, NameHash = 0x32822FA2FD268A65)]
    public class GcInventoryTable : NMSTemplate
    {
        /* 0x0000 */ public List<GcInventoryTableEntry> Table;
        /* 0x0010 */ public GcInventoryLayoutGenerationData GenerationData;
        /* 0x0D30 */ public GcInventoryCostData ShipCostData;
        [NMS(Size = 0x6, EnumType = typeof(GcWeaponClasses.WeaponStatClassEnum))]
        /* 0x0EC0 */ public GcInventoryCostDataEntry[] WeaponCostData;
        /* 0x0FB0 */ public GcInventoryCostDataEntry VehicleCostData;
        [NMS(Size = 0x4, EnumType = typeof(GcWealthClass.WealthClassEnum))]
        /* 0x0FD8 */ public GcInventoryClassProbabilities[] ClassProbabilityData;
        /* 0x1018 */ public GcInventoryGenerationBaseStatData VehicleBaseStatsData;
        [NMS(Size = 0xA, EnumType = typeof(GcSpaceshipClasses.ShipClassEnum))]
        /* 0x1058 */ public GcInventoryGenerationBaseStatData[] ShipBaseStatsData;
        [NMS(Size = 0x6, EnumType = typeof(GcWeaponClasses.WeaponStatClassEnum))]
        /* 0x12D8 */ public GcInventoryGenerationBaseStatData[] WeaponBaseStatsData;
        /* 0x1458 */ public List<GcInventoryBaseStat> BaseStats;
        [NMS(Size = 0xA, EnumType = typeof(GcSpaceshipClasses.ShipClassEnum))]
        /* 0x1468 */ public GcShipInventoryMaxUpgradeCapacity[] ShipInventoryMaxUpgradeSize;
        /* 0x1648 */ public GcWeaponInventoryMaxUpgradeCapacity WeaponInventoryMaxUpgradeSize;
    }
}
