using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0xEC80, GUID = 0xAA67829A2A9BCC87, NameHash = 0x392CEA8FE98D0F4)]
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

        [NMS(Size = 6)]
        /* 0x1E5C */ public GcScannerIcon[] GenericIcons;

        [NMS(Size = 0x13, EnumType = typeof(GcScannerBuildingIconTypes.ScanBuildingIconTypesEnum))]
        /* 0x24A4 */ public GcScannerIcon[] BuildingIcons;

        [NMS(Size = 0x13, EnumType = typeof(GcScannerBuildingIconTypes.ScanBuildingIconTypesEnum))]
        /* 0x3888 */ public GcScannerIcon[] BuildingIconsBinocs;

        [NMS(Size = 0x13, EnumType = typeof(GcScannerBuildingIconTypes.ScanBuildingIconTypesEnum))]
        /* 0x4C6C */ public GcScannerIcon[] BuildingIconsHuge;

        [NMS(Size = 0x30, EnumType = typeof(GcScannerIconTypes.ScanIconTypeEnum))]
        /* 0x6050 */ public GcScannerIcon[] ScannableIcons;

        [NMS(Size = 0x30, EnumType = typeof(GcScannerIconTypes.ScanIconTypeEnum))]
        /* 0x9290 */ public GcScannerIcon[] ScannableIconsBinocs;

        [NMS(Size = 0x30, EnumType = typeof(GcScannerIconTypes.ScanIconTypeEnum))]
        /* 0xC4D0 */ public Colour[] ScannableColours;

        /* 0xC7D0 */ public Colour BuildingColour;
        /* 0xC7E0 */ public Colour GenericColour;
        /* 0xC7F0 */ public Colour RelicColour;
        /* 0xC800 */ public Colour SignalColour;
        /* 0xC810 */ public Colour UnknownColour;

        /* 0xC820 */ public GcScannerIcon CreatureDiscovered;
        /* 0xC92C */ public GcScannerIcon CreatureUndiscovered;
        /* 0xCA38 */ public GcScannerIcon CreatureUnknown;
        /* 0xCB44 */ public GcScannerIcon MessageBeacon;
        /* 0xCC50 */ public GcScannerIcon MessageBeaconSmall;
        /* 0xCD5C */ public GcScannerIcon BaseBuildingMarker;
        /* 0xCE68 */ public GcScannerIcon PlanetNorthPole;
        /* 0xCF74 */ public GcScannerIcon PlanetSouthPole;
        /* 0xD080 */ public GcScannerIcon MonumentMarker;
        /* 0xD18C */ public GcScannerIcon NetworkPlayerMarker;
        /* 0xD298 */ public GcScannerIcon NetworkPlayerMarkerShip;
        /* 0xD3A4 */ public GcScannerIcon NetworkPlayerMarkerVehicle;
        
        [NMS(Size = 0x4)]
        /* 0xD4B0 */ public GcScannerIcon[] NetworkFSPlayerMarkers;
        [NMS(Size = 0x4)]
        /* 0xD8E0 */ public GcScannerIcon[] NetworkFSPlayerMarkersShip;
        [NMS(Size = 0x4)]
        /* 0xDD10 */ public Colour[] NetworkFSPlayerColours;
        [NMS(Size = 0x4)]
        /* 0xDD50 */ public GcScannerIcon[] NetworkPlayerFreighter;
        
        /* 0xE180 */ public GcScannerIcon PortalMarker;
        /* 0xE28C */ public GcScannerIcon BlackHole;
        /* 0xE398 */ public GcScannerIcon CreatureCurious;
        /* 0xE4A4 */ public GcScannerIcon CreatureAction;
        /* 0xE5B0 */ public GcScannerIcon CreatureTame;
        /* 0xE6BC */ public GcScannerIcon CreatureDanger;
        /* 0xE7C8 */ public GcScannerIcon CreatureFiend;
        /* 0xE8D4 */ public GcScannerIcon CreatureMilk;
        [NMS(Size = 0x5, EnumType = typeof(GcScannerIconHighlightTypes.ScannerIconHighlightTypeEnum))]
        /* 0xE9E0 */ public TkTextureResource[] HighlighIcons;

        [NMS(Size = 0xC, Ignore = true)]
        /* 0xEC74 */ public byte[] EndPadding;
    }
}
