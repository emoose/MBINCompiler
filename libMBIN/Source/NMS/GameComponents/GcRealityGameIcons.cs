using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x6FDD2A63BD224C75)]
    public class GcRealityGameIcons : NMSTemplate
    {
        // 0x42 entries
		public enum GameIconsEnum { Stamina, NoStamina, EnergyCharge, Scanner, NoScanner, Grave, Resources, Inventory, InventoryFull,
                                    RareItems, Pirates, PirateScan, Drone, Quad, Walker, DroneOff, Police, AtlasStation, BlackHole,
                                    SaveGame, Jetpack, JetpackEmpty, VehicleBoost, VehicleBoostRecharge, Fuel, GekStanding, VykeenStanding,
                                    KorvaxStanding, GekDiamondStanding, VykeenDiamondStanding, KorvaxDiamondStanding, TradeGuildStanding,
                                    WarGuildStanding, ExplorationGuildStanding, TradeGuildDiamondStanding, WarGuildDiamondStanding,
                                    ExplorationGuildDiamondStanding, GMPathToCentre, GMAtlas, GMBlackHole, GMUserWaypoint, GMUserMission,
                                    TransferPersonal, TransferPersonalCargo, TransferShip, TransferBike, TransferBuggy, TransferTruck,
                                    TransferWheeledBike, TransferHovercraft, TransferSubmarine, TransferFreighter, TransferBase, HazardIndicatorHot,
                                    HazardIndicatorCold, HazardIndicatorRadiation, HazardIndicatorToxic, TerrainAdd, TerrainRemove, TerrainUndo,
                                    SpacePhone, GarageMarkerBuggy, GarageMarkerBike, GarageMarkerTruck, GarageMarkerWheeledBike, GarageMarkerHovercraft }
		public GameIconsEnum GameIcons;
    }
}
