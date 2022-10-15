using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD88A086A63F7A7A3, NameHash = 0x32822FA2FD268A65)]
    public class GcInventoryTable : NMSTemplate
    {
        /* 0x0000 */ public List<GcInventoryTableEntry> Table;
        /* 0x0010 */ public GcInventoryLayoutGenerationData GenerationData;
        /* 0x0C34 */ public GcInventoryCostData ShipCostData;
        // size: 0x5
        public enum WeaponCostDataEnum {
            Pistol,
            Rifle,
            Pristine,
            Alien,
            Royal
        }
        [NMS(Size = 0x5, EnumType = typeof(WeaponCostDataEnum))]
        /* 0x0D9C */ public GcInventoryCostDataEntry[] WeaponCostData;
        /* 0x0E64 */ public GcInventoryCostDataEntry VehicleCostData;
        // size: 0x4
        public enum ClassProbabilityDataEnum {
            Poor,
            Average,
            Wealthy,
            Pirate
        }
        [NMS(Size = 0x4, EnumType = typeof(ClassProbabilityDataEnum))]
        /* 0x0E8C */ public GcInventoryClassProbabilities[] ClassProbabilityData;
        /* 0x0ED0 */ public GcInventoryGenerationBaseStatData VehicleBaseStatsData;
        // size: 0x9
        public enum ShipBaseStatsDataEnum {
            Freighter,
            Dropship,
            Fighter,
            Scientific,
            Shuttle,
            PlayerFreighter,
            Royal,
            Alien,
            Sail
        }
        [NMS(Size = 0x9, EnumType = typeof(ShipBaseStatsDataEnum))]
        /* 0x0F10 */ public GcInventoryGenerationBaseStatData[] ShipBaseStatsData;
        // size: 0x5
        public enum WeaponBaseStatsDataEnum {
            Pistol,
            Rifle,
            Pristine,
            Alien,
            Royal
        }
        [NMS(Size = 0x5, EnumType = typeof(WeaponBaseStatsDataEnum))]
        /* 0x1150 */ public GcInventoryGenerationBaseStatData[] WeaponBaseStatsData;
        /* 0x1290 */ public List<GcInventoryBaseStat> BaseStats;
        // size: 0x9
        public enum ShipInventoryMaxUpgradeSizeEnum {
            Freighter,
            Dropship,
            Fighter,
            Scientific,
            Shuttle,
            PlayerFreighter,
            Royal,
            Alien,
            Sail
        }
        [NMS(Size = 0x9, EnumType = typeof(ShipInventoryMaxUpgradeSizeEnum))]
        /* 0x12A0 */ public GcShipInventoryMaxUpgradeCapacity[] ShipInventoryMaxUpgradeSize;
        /* 0x1450 */ public GcWeaponInventoryMaxUpgradeCapacity WeaponInventoryMaxUpgradeSize;
    }
}
