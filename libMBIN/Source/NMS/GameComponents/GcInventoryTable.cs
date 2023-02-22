using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9D2794859AD00F81, NameHash = 0x32822FA2FD268A65)]
    public class GcInventoryTable : NMSTemplate
    {
        /* 0x0000 */ public List<GcInventoryTableEntry> Table;
        /* 0x0010 */ public GcInventoryLayoutGenerationData GenerationData;
        /* 0x0C34 */ public GcInventoryCostData ShipCostData;
        [NMS(Size = 0x5, EnumType = typeof(GcWeaponClasses.WeaponStatClassEnum))]
        /* 0x0D9C */ public GcInventoryCostDataEntry[] WeaponCostData;
        /* 0x0E64 */ public GcInventoryCostDataEntry VehicleCostData;
        [NMS(Size = 0x4, EnumType = typeof(GcWealthClass.WealthClassEnum))]
        /* 0x0E8C */ public GcInventoryClassProbabilities[] ClassProbabilityData;
        /* 0x0ED0 */ public GcInventoryGenerationBaseStatData VehicleBaseStatsData;
        [NMS(Size = 0x9, EnumType = typeof(GcSpaceshipClasses.ShipClassEnum))]
        /* 0x0F10 */ public GcInventoryGenerationBaseStatData[] ShipBaseStatsData;
        [NMS(Size = 0x5, EnumType = typeof(GcWeaponClasses.WeaponStatClassEnum))]
        /* 0x1150 */ public GcInventoryGenerationBaseStatData[] WeaponBaseStatsData;
        /* 0x1290 */ public List<GcInventoryBaseStat> BaseStats;
        [NMS(Size = 0x9, EnumType = typeof(GcSpaceshipClasses.ShipClassEnum))]
        /* 0x12A0 */ public GcShipInventoryMaxUpgradeCapacity[] ShipInventoryMaxUpgradeSize;
        /* 0x1450 */ public GcWeaponInventoryMaxUpgradeCapacity WeaponInventoryMaxUpgradeSize;
    }
}
