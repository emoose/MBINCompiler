using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xF39B7571584BDEC1, NameHash = 0x878911013D83AEE9)]
    public class GcRealityGameIcons : NMSTemplate
    {
        // 0x4B entries
		public enum GameIconsEnum {
            Stamina, NoStamina, EnergyCharge, Scanner, NoScanner, Grave, Resources, Inventory, InventoryFull, RareItems,
            Pirates, PirateScan, Drone, Quad, Walker, DroneOff, Police, AtlasStation, BlackHole, SaveGame,
            SaveInventory, Jetpack, JetpackEmpty, VehicleBoost, VehicleBoostRecharge, Fuel, GekStanding, VykeenStanding, KorvaxStanding, GekDiamondStanding,
            VykeenDiamondStanding, KorvaxDiamondStanding, TradeGuildStanding, WarGuildStanding, ExplorationGuildStanding, TradeGuildDiamondStanding, WarGuildDiamondStanding, ExplorationGuildDiamondStanding, GMPathToCentre, GMAtlas,
            GMBlackHole, GMUserWaypoint, GMUserMission, TransferPersonal, TransferPersonalCargo, TransferShip, TransferBike, TransferBuggy, TransferTruck, TransferWheeledBike,
            TransferHovercraft, TransferSubmarine, TransferFreighter, TransferBase, HazardIndicatorHot, HazardIndicatorCold, HazardIndicatorRadiation, HazardIndicatorToxic, TerrainAdd, TerrainRemove,
            TerrainFlatten, TerrainUndo, SpacePhone, GarageMarkerBuggy, GarageMarkerBike, GarageMarkerTruck, GarageMarkerWheeledBike, GarageMarkerHovercraft, CorruptedDrone, HandHold,
            ShipThumbnailBG, CClass, BClass, AClass, SClass
        }
		public GameIconsEnum GameIcons;
    }
}
