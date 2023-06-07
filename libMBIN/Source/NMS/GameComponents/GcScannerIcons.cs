using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAE61E4EEBA39371E, NameHash = 0x392CEA8FE98D0F4)]
    public class GcScannerIcons : NMSTemplate
    {
        /* 0x00000 */ public GcScannerIcon TaggedBuilding;
        /* 0x0010C */ public GcScannerIcon Ship;
        /* 0x00218 */ public GcScannerIcon Vehicle;
        /* 0x00324 */ public GcScannerIcon Freighter;
        /* 0x00430 */ public GcScannerIcon FreighterBase;
        /* 0x0053C */ public GcScannerIcon PlayerFreighter;
        /* 0x00648 */ public GcScannerIcon DamagedFrigate;
        /* 0x00754 */ public GcScannerIcon PurchasableFrigate;
        /* 0x00860 */ public GcScannerIcon Expedition;
        /* 0x0096C */ public GcScannerIcon PlayerBase;
        /* 0x00A78 */ public GcScannerIcon EditingBase;
        /* 0x00B84 */ public GcScannerIcon Death;
        /* 0x00C90 */ public GcScannerIcon Bounty1;
        /* 0x00D9C */ public GcScannerIcon Bounty2;
        /* 0x00EA8 */ public GcScannerIcon Bounty3;
        /* 0x00FB4 */ public GcScannerIcon Battle;
        /* 0x010C0 */ public GcScannerIcon ShipSmall;
        /* 0x011CC */ public GcScannerIcon DeathSmall;
        /* 0x012D8 */ public GcScannerIcon BountySmall;
        /* 0x013E4 */ public GcScannerIcon BattleSmall;
        /* 0x014F0 */ public GcScannerIcon TimedEvent;
        /* 0x015FC */ public GcScannerIcon Checkpoint;
        /* 0x01708 */ public GcScannerIcon Garage;
        /* 0x01814 */ public GcScannerIcon NPC;
        /* 0x01920 */ public GcScannerIcon SettlementNPC;
        /* 0x01A2C */ public GcScannerIcon CircleAnimation;
        /* 0x01B38 */ public GcScannerIcon HexAnimation;
        /* 0x01C44 */ public GcScannerIcon DiamondAnimation;
        /* 0x01D50 */ public GcScannerIcon ArrowSmall;
        /* 0x01E5C */ public GcScannerIcon ArrowLarge;
        [NMS(Size = 0x6, EnumType = typeof(GcGenericIconTypes.GenericIconTypeEnum))]
        /* 0x01F68 */ public GcScannerIcon[] GenericIcons;
        [NMS(Size = 0x23, EnumType = typeof(GcScannerBuildingIconTypes.ScanBuildingIconTypeEnum))]
        /* 0x025B0 */ public GcScannerIcon[] BuildingIcons;
        [NMS(Size = 0x23, EnumType = typeof(GcScannerBuildingIconTypes.ScanBuildingIconTypeEnum))]
        /* 0x04A54 */ public GcScannerIcon[] BuildingIconsBinocs;
        [NMS(Size = 0x23, EnumType = typeof(GcScannerBuildingIconTypes.ScanBuildingIconTypeEnum))]
        /* 0x06EF8 */ public GcScannerIcon[] BuildingIconsHuge;
        [NMS(Size = 0x3A, EnumType = typeof(GcScannerIconTypes.ScanIconTypeEnum))]
        /* 0x0939C */ public GcScannerIcon[] ScannableIcons;
        [NMS(Size = 0x3A, EnumType = typeof(GcScannerIconTypes.ScanIconTypeEnum))]
        /* 0x0D054 */ public GcScannerIcon[] ScannableIconsBinocs;
        [NMS(Size = 0x3A, EnumType = typeof(GcScannerIconTypes.ScanIconTypeEnum))]
        /* 0x10D10 */ public Colour[] ScannableColours;
        /* 0x110B0 */ public Colour BuildingColour;
        /* 0x110C0 */ public Colour GenericColour;
        /* 0x110D0 */ public Colour RelicColour;
        /* 0x110E0 */ public Colour SignalColour;
        /* 0x110F0 */ public Colour UnknownColour;
        /* 0x11100 */ public GcScannerIcon CreatureDiscovered;
        /* 0x1120C */ public GcScannerIcon CreatureUndiscovered;
        /* 0x11318 */ public GcScannerIcon CreatureUnknown;
        /* 0x11424 */ public GcScannerIcon MessageBeacon;
        /* 0x11530 */ public GcScannerIcon MessageBeaconSmall;
        /* 0x1163C */ public GcScannerIcon BaseBuildingMarker;
        /* 0x11748 */ public GcScannerIcon PlanetPoleNorth;
        /* 0x11854 */ public GcScannerIcon PlanetPoleSouth;
        /* 0x11960 */ public GcScannerIcon MonumentMarker;
        /* 0x11A6C */ public GcScannerIcon NetworkPlayerMarker;
        /* 0x11B78 */ public GcScannerIcon NetworkPlayerMarkerShip;
        /* 0x11C84 */ public GcScannerIcon NetworkPlayerMarkerVehicle;
        [NMS(Size = 0x4)]
        /* 0x11D90 */ public GcScannerIcon[] NetworkFSPlayerMarkers;
        [NMS(Size = 0x4)]
        /* 0x121C0 */ public GcScannerIcon[] NetworkFSPlayerMarkersShip;
        [NMS(Size = 0x4)]
        /* 0x125F0 */ public Colour[] NetworkFSPlayerColours;
        [NMS(Size = 0x4)]
        /* 0x12630 */ public GcScannerIcon[] NetworkPlayerFreighter;
        /* 0x12A60 */ public GcScannerIcon PortalMarker;
        /* 0x12B6C */ public GcScannerIcon BlackHole;
        /* 0x12C78 */ public GcScannerIcon CreatureCurious;
        /* 0x12D84 */ public GcScannerIcon CreatureAction;
        /* 0x12E90 */ public GcScannerIcon CreatureTame;
        /* 0x12F9C */ public GcScannerIcon CreatureDanger;
        /* 0x130A8 */ public GcScannerIcon CreatureFiend;
        /* 0x131B4 */ public GcScannerIcon CreatureMilk;
        [NMS(Size = 0x5, EnumType = typeof(GcScannerIconHighlightTypes.ScannerIconHighlightTypeEnum))]
        /* 0x132C0 */ public TkTextureResource[] HighlightIcons;
        /* 0x13554 */ public GcScannerIcon MissionEnterOrbit;
        /* 0x13660 */ public GcScannerIcon MissionEnterBuilding;
        /* 0x1376C */ public GcScannerIcon MissionEnterStation;
        /* 0x13878 */ public GcScannerIcon MissionEnterFreighter;
        /* 0x13984 */ public GcScannerIcon MissionAbandonedFreighter;
        /* 0x13A90 */ public GcScannerIcon CreatureInteraction;
        /* 0x13B9C */ public GcScannerIcon PetInteraction;
        /* 0x13CA8 */ public GcScannerIcon Pet;
        /* 0x13DB4 */ public GcScannerIcon PetSad;
        /* 0x13EC0 */ public GcScannerIcon PetActivity;
        /* 0x13FCC */ public GcScannerIcon PlayerSettlement;
        /* 0x140D8 */ public GcScannerIcon OtherPlayerSettlement;
        /* 0x141E4 */ public GcScannerIcon FriendlyDrone;
        /* 0x142F0 */ public GcScannerIcon PirateRaid;
        /* 0x143FC */ public GcScannerIcon FuelAsteroid;
    }
}
