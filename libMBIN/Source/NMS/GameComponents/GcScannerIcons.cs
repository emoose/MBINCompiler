using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x12DC0, GUID = 0xB379FA50914ED263, NameHash = 0x392CEA8FE98D0F4)]
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
        /* 0x01700 */ public GcScannerIcon Garage;
        /* 0x01814 */ public GcScannerIcon NPC;
        /* 0x01920 */ public GcScannerIcon SettlementNPC;
        /* 0x01A2C */ public GcScannerIcon CircleAnimation;
        /* 0x01B38 */ public GcScannerIcon HexAnimation;
        /* 0x01C44 */ public GcScannerIcon DiamondAnimation;
        /* 0x01D50 */ public GcScannerIcon ArrowSmall;
        /* 0x01E6C */ public GcScannerIcon ArrowLarge;
        [NMS(Size = 0x6, EnumType = typeof(GcGenericIconTypes.GenericIconTypeEnum))]
        /* 0x01F68 */ public GcScannerIcon[] GenericIcons;
        [NMS(Size = 0x20, EnumType = typeof(GcScannerBuildingIconTypes.ScanBuildingIconTypesEnum))]
        /* 0x025B0 */ public GcScannerIcon[] BuildingIcons;
        [NMS(Size = 0x20, EnumType = typeof(GcScannerBuildingIconTypes.ScanBuildingIconTypesEnum))]
        /* 0x04730 */ public GcScannerIcon[] BuildingIconsBinocs;
        [NMS(Size = 0x20, EnumType = typeof(GcScannerBuildingIconTypes.ScanBuildingIconTypesEnum))]
        /* 0x068B0 */ public GcScannerIcon[] BuildingIconsHuge;
        [NMS(Size = 0x35, EnumType = typeof(GcScannerIconTypes.ScanIconTypeEnum))]
        /* 0x08A30 */ public GcScannerIcon[] ScannableIcons;
        [NMS(Size = 0x35, EnumType = typeof(GcScannerIconTypes.ScanIconTypeEnum))]
        /* 0x0C1AC */ public GcScannerIcon[] ScannableIconsBinocs;
        [NMS(Size = 0x35, EnumType = typeof(GcScannerIconTypes.ScanIconTypeEnum))]
        /* 0x0F930 */ public Colour[] ScannableColours;
        /* 0x0FC80 */ public Colour BuildingColour;
        /* 0x0FC90 */ public Colour GenericColour;
        /* 0x0FCA0 */ public Colour RelicColour;
        /* 0x0FCB0 */ public Colour SignalColour;
        /* 0x0FCC0 */ public Colour UnknownColour;
        /* 0x0FCD0 */ public GcScannerIcon CreatureDiscovered;
        /* 0x0FDDC */ public GcScannerIcon CreatureUndiscovered;
        /* 0x0FEE8 */ public GcScannerIcon CreatureUnknown;
        /* 0x0FFF4 */ public GcScannerIcon MessageBeacon;
        /* 0x10100 */ public GcScannerIcon MessageBeaconSmall;
        /* 0x1020C */ public GcScannerIcon BaseBuildingMarker;
        /* 0x10318 */ public GcScannerIcon PlanetNorthPole;
        /* 0x10424 */ public GcScannerIcon PlanetSouthPole;
        /* 0x10530 */ public GcScannerIcon MonumentMarker;
        /* 0x1063C */ public GcScannerIcon NetworkPlayerMarker;
        /* 0x10748 */ public GcScannerIcon NetworkPlayerMarkerShip;
        /* 0x10854 */ public GcScannerIcon NetworkPlayerMarkerVehicle;
        [NMS(Size = 0x4)]
        /* 0x10960 */ public GcScannerIcon[] NetworkFSPlayerMarkers;
        [NMS(Size = 0x4)]
        /* 0x10D90 */ public GcScannerIcon[] NetworkFSPlayerMarkersShip;
        [NMS(Size = 0x4)]
        /* 0x111C0 */ public Colour[] NetworkFSPlayerColours;
        [NMS(Size = 0x4)]
        /* 0x11200 */ public GcScannerIcon[] NetworkPlayerFreighter;
        /* 0x11630 */ public GcScannerIcon PortalMarker;
        /* 0x1173C */ public GcScannerIcon BlackHole;
        /* 0x11848 */ public GcScannerIcon CreatureCurious;
        /* 0x11954 */ public GcScannerIcon CreatureAction;
        /* 0x11A60 */ public GcScannerIcon CreatureTame;
        /* 0x11B6C */ public GcScannerIcon CreatureDanger;
        /* 0x11C78 */ public GcScannerIcon CreatureFiend;
        /* 0x11D84 */ public GcScannerIcon CreatureMilk;
        [NMS(Size = 0x5, EnumType = typeof(GcScannerIconHighlightTypes.ScannerIconHighlightTypeEnum))]
        /* 0x11E90 */ public TkTextureResource[] HighlightIcons;
        /* 0x12124 */ public GcScannerIcon MissionEnterOrbit;
        /* 0x12230 */ public GcScannerIcon MissionEnterBuilding;
        /* 0x1233C */ public GcScannerIcon MissionEnterStation;
        /* 0x12448 */ public GcScannerIcon MissionEnterFreighter;
        /* 0x12554 */ public GcScannerIcon MissionAbandonedFreighter;
        /* 0x12660 */ public GcScannerIcon CreatureInteraction;
        /* 0x1276C */ public GcScannerIcon PetInteraction;
        /* 0x12878 */ public GcScannerIcon Pet;
        /* 0x12984 */ public GcScannerIcon PetSad;
        /* 0x12A90 */ public GcScannerIcon PetActivity;
        /* 0x12B9C */ public GcScannerIcon PlayerSettlement;
        /* 0x12CA8 */ public GcScannerIcon OtherPlayerSettlement;
    }
}
