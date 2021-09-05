using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x12B90, GUID = 0xB379FA50914ED263, NameHash = 0x392CEA8FE98D0F4)]
    public class GcScannerIcons : NMSTemplate
    {
        /* 0x0000 */ public GcScannerIcon TaggedBuilding;
        /* 0x010C */ public GcScannerIcon Ship;
        /* 0x0218 */ public GcScannerIcon Vehicle;
        /* 0x0324 */ public GcScannerIcon Freighter;
        /* 0x0430 */ public GcScannerIcon FreighterBase;
        /* 0x053C */ public GcScannerIcon PlayerFreighter;
        /* 0x0648 */ public GcScannerIcon DamagedFrigate;
        /* 0x0754 */ public GcScannerIcon PurchasableFrigate;
        /* 0x0860 */ public GcScannerIcon Expedition;
        /* 0x096C */ public GcScannerIcon PlayerBase;
        /* 0x0A78 */ public GcScannerIcon EditingBase;
        /* 0x0B84 */ public GcScannerIcon Death;
        /* 0x0C90 */ public GcScannerIcon Bounty1;
        /* 0x0D9C */ public GcScannerIcon Bounty2;
        /* 0x0EA8 */ public GcScannerIcon Bounty3;
        /* 0x0FB4 */ public GcScannerIcon Battle;
        /* 0x10C0 */ public GcScannerIcon ShipSmall;
        /* 0x11CC */ public GcScannerIcon DeathSmall;
        /* 0x12D8 */ public GcScannerIcon BountySmall;
        /* 0x13E4 */ public GcScannerIcon BattleSmall;
        /* 0x14F0 */ public GcScannerIcon TimedEvent;
        /* 0x15FC */ public GcScannerIcon Checkpoint;
        /* 0x1700 */ public GcScannerIcon Garage;
        /* 0x1814 */ public GcScannerIcon NPC;
        /* 0x1920 */ public GcScannerIcon SettlementNPC;
        /* 0x1A2C */ public GcScannerIcon CircleAnimation;
        /* 0x1B38 */ public GcScannerIcon HexAnimation;
        /* 0x1C44 */ public GcScannerIcon DiamondAnimation;
        /* 0x1D50 */ public GcScannerIcon ArrowSmall;
        /* 0x1E5C */ public GcScannerIcon ArrowLarge;
        [NMS(Size = 0x6, EnumType = typeof(GcGenericIconTypes.GenericIconTypeEnum))]
        /* 0x1F68 */ public GcScannerIcon[] GenericIcons;
        [NMS(Size = 0x20, EnumType = typeof(GcScannerBuildingIconTypes.ScanBuildingIconTypesEnum))]
        /* 0x25B0 */ public GcScannerIcon[] BuildingIcons;
        [NMS(Size = 0x20, EnumType = typeof(GcScannerBuildingIconTypes.ScanBuildingIconTypesEnum))]
        /* 0x4730 */ public GcScannerIcon[] BuildingIconsBinocs;
        [NMS(Size = 0x20, EnumType = typeof(GcScannerBuildingIconTypes.ScanBuildingIconTypesEnum))]
        /* 0x68B0 */ public GcScannerIcon[] BuildingIconsHuge;
        [NMS(Size = 0x34, EnumType = typeof(GcScannerIconTypes.ScanIconTypeEnum))]
        /* 0x8A30 */ public GcScannerIcon[] ScannableIcons;
        [NMS(Size = 0x34, EnumType = typeof(GcScannerIconTypes.ScanIconTypeEnum))]
        /* 0xC0A0 */ public GcScannerIcon[] ScannableIconsBinocs;
        [NMS(Size = 0x34, EnumType = typeof(GcScannerIconTypes.ScanIconTypeEnum))]
        /* 0xF710 */ public Colour[] ScannableColours;
        /* 0xFA50 */ public Colour BuildingColour;
        /* 0xFA60 */ public Colour GenericColour;
        /* 0xFA70 */ public Colour RelicColour;
        /* 0xFA80 */ public Colour SignalColour;
        /* 0xFA90 */ public Colour UnknownColour;
        /* 0xFAA0 */ public GcScannerIcon CreatureDiscovered;
        /* 0xFBAC */ public GcScannerIcon CreatureUndiscovered;
        /* 0xFCB8 */ public GcScannerIcon CreatureUnknown;
        /* 0xFDC4 */ public GcScannerIcon MessageBeacon;
        /* 0xFED0 */ public GcScannerIcon MessageBeaconSmall;
        /* 0xFFDC */ public GcScannerIcon BaseBuildingMarker;
        /* 0x100E8 */ public GcScannerIcon PlanetNorthPole;
        /* 0x101F4 */ public GcScannerIcon PlanetSouthPole;
        /* 0x10300 */ public GcScannerIcon MonumentMarker;
        /* 0x1040C */ public GcScannerIcon NetworkPlayerMarker;
        /* 0x10518 */ public GcScannerIcon NetworkPlayerMarkerShip;
        /* 0x10624 */ public GcScannerIcon NetworkPlayerMarkerVehicle;
        [NMS(Size = 0x4)]
        /* 0x10730 */ public GcScannerIcon[] NetworkFSPlayerMarkers;
        [NMS(Size = 0x4)]
        /* 0x10B60 */ public GcScannerIcon[] NetworkFSPlayerMarkersShip;
        [NMS(Size = 0x4)]
        /* 0x10F90 */ public Colour[] NetworkFSPlayerColours;
        [NMS(Size = 0x4)]
        /* 0x10FD0 */ public GcScannerIcon[] NetworkPlayerFreighter;
        /* 0x11400 */ public GcScannerIcon PortalMarker;
        /* 0x1150C */ public GcScannerIcon BlackHole;
        /* 0x11618 */ public GcScannerIcon CreatureCurious;
        /* 0x11724 */ public GcScannerIcon CreatureAction;
        /* 0x11830 */ public GcScannerIcon CreatureTame;
        /* 0x1193C */ public GcScannerIcon CreatureDanger;
        /* 0x11A48 */ public GcScannerIcon CreatureFiend;
        /* 0x11B54 */ public GcScannerIcon CreatureMilk;
        [NMS(Size = 0x5, EnumType = typeof(GcScannerIconHighlightTypes.ScannerIconHighlightTypeEnum))]
        /* 0x11C60 */ public TkTextureResource[] HighlightIcons;
        /* 0x11EF4 */ public GcScannerIcon MissionEnterOrbit;
        /* 0x12000 */ public GcScannerIcon MissionEnterBuilding;
        /* 0x1210C */ public GcScannerIcon MissionEnterStation;
        /* 0x12218 */ public GcScannerIcon MissionEnterFreighter;
        /* 0x12324 */ public GcScannerIcon MissionAbandonedFreighter;
        /* 0x12430 */ public GcScannerIcon CreatureInteraction;
        /* 0x1253C */ public GcScannerIcon PetInteraction;
        /* 0x12648 */ public GcScannerIcon Pet;
        /* 0x12754 */ public GcScannerIcon PetSad;
        /* 0x12860 */ public GcScannerIcon PetActivity;
        /* 0x1296C */ public GcScannerIcon PlayerSettlement;
        /* 0x12A78 */ public GcScannerIcon OtherPlayerSettlement;
    }
}
