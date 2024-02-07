using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x46127FC79E756668, NameHash = 0x32822FA2FD268A65)]
    public class GcInventoryTable : NMSTemplate
    {
        /* 0x0000 */ public List<GcInventoryTableEntry> Table;
        /* 0x0010 */ public GcInventoryLayoutGenerationData GenerationData;
        /* 0x0D30 */ public GcInventoryCostData ShipCostData;
        [NMS(Size = 0xA, EnumType = typeof(GcWeaponClasses.WeaponStatClassEnum))]
        /* 0x0EC0 */ public GcInventoryCostDataEntry[] WeaponCostData;
        /* 0x1050 */ public GcInventoryCostDataEntry VehicleCostData;
        [NMS(Size = 0x4, EnumType = typeof(GcWealthClass.WealthClassEnum))]
        /* 0x1078 */ public GcInventoryClassProbabilities[] ClassProbabilityData;
        /* 0x10B8 */ public GcInventoryGenerationBaseStatData VehicleBaseStatsData;
        [NMS(Size = 0xA, EnumType = typeof(GcSpaceshipClasses.ShipClassEnum))]
        /* 0x10F8 */ public GcInventoryGenerationBaseStatData[] ShipBaseStatsData;
        [NMS(Size = 0xA, EnumType = typeof(GcWeaponClasses.WeaponStatClassEnum))]
        /* 0x1378 */ public GcInventoryGenerationBaseStatData[] WeaponBaseStatsData;
        /* 0x15F8 */ public List<GcInventoryBaseStat> BaseStats;
        [NMS(Size = 0xA, EnumType = typeof(GcSpaceshipClasses.ShipClassEnum))]
        /* 0x1608 */ public GcShipInventoryMaxUpgradeCapacity[] ShipInventoryMaxUpgradeSize;
        /* 0x17E8 */ public GcWeaponInventoryMaxUpgradeCapacity WeaponInventoryMaxUpgradeSize;
    }
}
