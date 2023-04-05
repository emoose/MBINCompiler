using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x56D7F3CBAB2117E0, NameHash = 0x392CEA8FE98D0F4)]
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
        [NMS(Size = 0x39, EnumType = typeof(GcScannerIconTypes.ScanIconTypeEnum))]
        /* 0x0939C */ public GcScannerIcon[] ScannableIcons;
        [NMS(Size = 0x39, EnumType = typeof(GcScannerIconTypes.ScanIconTypeEnum))]
        /* 0x0CF48 */ public GcScannerIcon[] ScannableIconsBinocs;
        [NMS(Size = 0x39, EnumType = typeof(GcScannerIconTypes.ScanIconTypeEnum))]
        /* 0x10B00 */ public Colour[] ScannableColours;
        /* 0x10E90 */ public Colour BuildingColour;
        /* 0x10EA0 */ public Colour GenericColour;
        /* 0x10EB0 */ public Colour RelicColour;
        /* 0x10EC0 */ public Colour SignalColour;
        /* 0x10ED0 */ public Colour UnknownColour;
        /* 0x10EE0 */ public GcScannerIcon CreatureDiscovered;
        /* 0x10FEC */ public GcScannerIcon CreatureUndiscovered;
        /* 0x110F8 */ public GcScannerIcon CreatureUnknown;
        /* 0x11204 */ public GcScannerIcon MessageBeacon;
        /* 0x11310 */ public GcScannerIcon MessageBeaconSmall;
        /* 0x1141C */ public GcScannerIcon BaseBuildingMarker;
        /* 0x11528 */ public GcScannerIcon PlanetPoleNorth;
        /* 0x11634 */ public GcScannerIcon PlanetPoleSouth;
        /* 0x11740 */ public GcScannerIcon MonumentMarker;
        /* 0x1184C */ public GcScannerIcon NetworkPlayerMarker;
        /* 0x11958 */ public GcScannerIcon NetworkPlayerMarkerShip;
        /* 0x11A64 */ public GcScannerIcon NetworkPlayerMarkerVehicle;
        [NMS(Size = 0x4)]
        /* 0x11B70 */ public GcScannerIcon[] NetworkFSPlayerMarkers;
        [NMS(Size = 0x4)]
        /* 0x11FA0 */ public GcScannerIcon[] NetworkFSPlayerMarkersShip;
        [NMS(Size = 0x4)]
        /* 0x123D0 */ public Colour[] NetworkFSPlayerColours;
        [NMS(Size = 0x4)]
        /* 0x12410 */ public GcScannerIcon[] NetworkPlayerFreighter;
        /* 0x12840 */ public GcScannerIcon PortalMarker;
        /* 0x1294C */ public GcScannerIcon BlackHole;
        /* 0x12A58 */ public GcScannerIcon CreatureCurious;
        /* 0x12B64 */ public GcScannerIcon CreatureAction;
        /* 0x12C70 */ public GcScannerIcon CreatureTame;
        /* 0x12D7C */ public GcScannerIcon CreatureDanger;
        /* 0x12E88 */ public GcScannerIcon CreatureFiend;
        /* 0x12F94 */ public GcScannerIcon CreatureMilk;
        [NMS(Size = 0x5, EnumType = typeof(GcScannerIconHighlightTypes.ScannerIconHighlightTypeEnum))]
        /* 0x130A0 */ public TkTextureResource[] HighlightIcons;
        /* 0x13334 */ public GcScannerIcon MissionEnterOrbit;
        /* 0x13440 */ public GcScannerIcon MissionEnterBuilding;
        /* 0x1354C */ public GcScannerIcon MissionEnterStation;
        /* 0x13658 */ public GcScannerIcon MissionEnterFreighter;
        /* 0x13764 */ public GcScannerIcon MissionAbandonedFreighter;
        /* 0x13870 */ public GcScannerIcon CreatureInteraction;
        /* 0x1397C */ public GcScannerIcon PetInteraction;
        /* 0x13A88 */ public GcScannerIcon Pet;
        /* 0x13B94 */ public GcScannerIcon PetSad;
        /* 0x13CA0 */ public GcScannerIcon PetActivity;
        /* 0x13DAC */ public GcScannerIcon PlayerSettlement;
        /* 0x13EB8 */ public GcScannerIcon OtherPlayerSettlement;
        /* 0x13FC4 */ public GcScannerIcon FriendlyDrone;
        /* 0x140D0 */ public GcScannerIcon PirateRaid;
        /* 0x141DC */ public GcScannerIcon FuelAsteroid;
    }
}
