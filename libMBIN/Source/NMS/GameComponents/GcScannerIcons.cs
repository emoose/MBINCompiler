using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0xFB40, GUID = 0xAAF97EB9DB2E77B9, NameHash = 0x392CEA8FE98D0F4)]
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
        /* 0x1920 */ public GcScannerIcon CircleAnimation;
        /* 0x1A2C */ public GcScannerIcon HexAnimation;
        /* 0x1B38 */ public GcScannerIcon DiamondAnimation;
        /* 0x1C44 */ public GcScannerIcon ArrowSmall;
        /* 0x1D50 */ public GcScannerIcon ArrowLarge;
        [NMS(Size = 6, EnumType = typeof(GcGenericIconTypes.GenericIconTypeEnum))]
        /* 0x1E5C */ public GcScannerIcon[] GenericIcons;
        [NMS(Size = 0x13, EnumType = typeof(GcScannerBuildingIconTypes.ScanBuildingIconTypesEnum))]
        /* 0x24A4 */ public GcScannerIcon[] BuildingIcons;
        [NMS(Size = 0x13, EnumType = typeof(GcScannerBuildingIconTypes.ScanBuildingIconTypesEnum))]
        /* 0x3888 */ public GcScannerIcon[] BuildingIconsBinocs;
        [NMS(Size = 0x13, EnumType = typeof(GcScannerBuildingIconTypes.ScanBuildingIconTypesEnum))]
        /* 0x4C6C */ public GcScannerIcon[] BuildingIconsHuge;
        [NMS(Size = 0x32, EnumType = typeof(GcScannerIconTypes.ScanIconTypeEnum))]
        /* 0x6050 */ public GcScannerIcon[] ScannableIcons;
        [NMS(Size = 0x32, EnumType = typeof(GcScannerIconTypes.ScanIconTypeEnum))]
        /* 0x94A8 */ public GcScannerIcon[] ScannableIconsBinocs;
        [NMS(Size = 0x32, EnumType = typeof(GcScannerIconTypes.ScanIconTypeEnum))]
        /* 0xC900 */ public Colour[] ScannableColours;
        /* 0xCC20 */ public Colour BuildingColour;
        /* 0xCC30 */ public Colour GenericColour;
        /* 0xCC40 */ public Colour RelicColour;
        /* 0xCC50 */ public Colour SignalColour;
        /* 0xCC60 */ public Colour UnknownColour;
        /* 0xCC70 */ public GcScannerIcon CreatureDiscovered;
        /* 0xCD7C */ public GcScannerIcon CreatureUndiscovered;
        /* 0xCE88 */ public GcScannerIcon CreatureUnknown;
        /* 0xCF94 */ public GcScannerIcon MessageBeacon;
        /* 0xD0A0 */ public GcScannerIcon MessageBeaconSmall;
        /* 0xD1AC */ public GcScannerIcon BaseBuildingMarker;
        /* 0xD2B8 */ public GcScannerIcon PlanetNorthPole;
        /* 0xD3C4 */ public GcScannerIcon PlanetSouthPole;
        /* 0xD4D0 */ public GcScannerIcon MonumentMarker;
        /* 0xD5DC */ public GcScannerIcon NetworkPlayerMarker;
        /* 0xD6E8 */ public GcScannerIcon NetworkPlayerMarkerShip;
        /* 0xD7F4 */ public GcScannerIcon NetworkPlayerMarkerVehicle;
        [NMS(Size = 0x4)]
        /* 0xD900 */ public GcScannerIcon[] NetworkFSPlayerMarkers;
        [NMS(Size = 0x4)]
        /* 0xDD30 */ public GcScannerIcon[] NetworkFSPlayerMarkersShip;
        [NMS(Size = 0x4)]
        /* 0xE160 */ public Colour[] NetworkFSPlayerColours;
        [NMS(Size = 0x4)]
        /* 0xE1A0 */ public GcScannerIcon[] NetworkPlayerFreighter;
        /* 0xE5D0 */ public GcScannerIcon PortalMarker;
        /* 0xE6DC */ public GcScannerIcon BlackHole;
        /* 0xE7E8 */ public GcScannerIcon CreatureCurious;
        /* 0xE8F4 */ public GcScannerIcon CreatureAction;
        /* 0xEA00 */ public GcScannerIcon CreatureTame;
        /* 0xEB0C */ public GcScannerIcon CreatureDanger;
        /* 0xEC18 */ public GcScannerIcon CreatureFiend;
        /* 0xED24 */ public GcScannerIcon CreatureMilk;
        [NMS(Size = 0x5, EnumType = typeof(GcScannerIconHighlightTypes.ScannerIconHighlightTypeEnum))]
        /* 0xEE30 */ public TkTextureResource[] HighlightIcons;
        /* 0xF0C4 */ public GcScannerIcon MissionEnterOrbit;
        /* 0xF1D0 */ public GcScannerIcon MissionEnterBuilding;
        /* 0xF2DC */ public GcScannerIcon MissionEnterStation;
        /* 0xF3E8 */ public GcScannerIcon MissionEnterFreighter;
        /* 0xF4F4 */ public GcScannerIcon MissionAbandonedFreighter;
        /* 0xF600 */ public GcScannerIcon CreatureInteraction;
        /* 0xF70C */ public GcScannerIcon PetInteraction;
        /* 0xF818 */ public GcScannerIcon Pet;
        /* 0xF924 */ public GcScannerIcon PetSad;
        /* 0xFA30 */ public GcScannerIcon PetActivity;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0xFB3C */ public byte[] EndPadding;
    }
}
