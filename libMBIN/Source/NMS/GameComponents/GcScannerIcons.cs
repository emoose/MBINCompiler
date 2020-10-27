using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0xF3E0, GUID = 0x8F68138760D07B3C, NameHash = 0x392CEA8FE98D0F4)]
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
        [NMS(Size = 0x31, EnumType = typeof(GcScannerIconTypes.ScanIconTypeEnum))]
        /* 0x6050 */ public GcScannerIcon[] ScannableIcons;
        [NMS(Size = 0x31, EnumType = typeof(GcScannerIconTypes.ScanIconTypeEnum))]
        /* 0x939C */ public GcScannerIcon[] ScannableIconsBinocs;
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x96E8 */ public byte[] Padding96E8;
        [NMS(Size = 0x31, EnumType = typeof(GcScannerIconTypes.ScanIconTypeEnum))]
        /* 0xC6F0 */ public Colour[] ScannableColours;
        /* 0xCA00 */ public Colour BuildingColour;
        /* 0xCA10 */ public Colour GenericColour;
        /* 0xCA20 */ public Colour RelicColour;
        /* 0xCA30 */ public Colour SignalColour;
        /* 0xCA40 */ public Colour UnknownColour;
        /* 0xCA50 */ public GcScannerIcon CreatureDiscovered;
        /* 0xCB5C */ public GcScannerIcon CreatureUndiscovered;
        /* 0xCC68 */ public GcScannerIcon CreatureUnknown;
        /* 0xCD74 */ public GcScannerIcon MessageBeacon;
        /* 0xCE80 */ public GcScannerIcon MessageBeaconSmall;
        /* 0xCF8C */ public GcScannerIcon BaseBuildingMarker;
        /* 0xD098 */ public GcScannerIcon PlanetNorthPole;
        /* 0xD1A4 */ public GcScannerIcon PlanetSouthPole;
        /* 0xD2B0 */ public GcScannerIcon MonumentMarker;
        /* 0xD3BC */ public GcScannerIcon NetworkPlayerMarker;
        /* 0xD4C8 */ public GcScannerIcon NetworkPlayerMarkerShip;
        /* 0xD5D4 */ public GcScannerIcon NetworkPlayerMarkerVehicle;
        [NMS(Size = 0x4)]
        /* 0xD6E0 */ public GcScannerIcon[] NetworkFSPlayerMarkers;
        [NMS(Size = 0x4)]
        /* 0xDB10 */ public GcScannerIcon[] NetworkFSPlayerMarkersShip;
        [NMS(Size = 0x4)]
        /* 0xDF40 */ public Colour[] NetworkFSPlayerColours;
        [NMS(Size = 0x4)]
        /* 0xDF80 */ public GcScannerIcon[] NetworkPlayerFreighter;
        /* 0xE3B0 */ public GcScannerIcon PortalMarker;
        /* 0xE4BC */ public GcScannerIcon BlackHole;
        /* 0xE5C8 */ public GcScannerIcon CreatureCurious;
        /* 0xE6D4 */ public GcScannerIcon CreatureAction;
        /* 0xE7E0 */ public GcScannerIcon CreatureTame;
        /* 0xE8EC */ public GcScannerIcon CreatureDanger;
        /* 0xE9F8 */ public GcScannerIcon CreatureFiend;
        /* 0xEB04 */ public GcScannerIcon CreatureMilk;
        [NMS(Size = 0x5, EnumType = typeof(GcScannerIconHighlightTypes.ScannerIconHighlightTypeEnum))]
        /* 0xEC10 */ public TkTextureResource[] HighlightIcons;
        /* 0xEEA4 */ public GcScannerIcon MissionEnterOrbit;
        /* 0xEFB0 */ public GcScannerIcon MissionEnterBuilding;
        /* 0xF0BC */ public GcScannerIcon MissionEnterStation;
        /* 0xF1C8 */ public GcScannerIcon MissionEnterFreighter;
        /* 0xF2D4 */ public GcScannerIcon MissionAbandonedFreighter;
    }
}
