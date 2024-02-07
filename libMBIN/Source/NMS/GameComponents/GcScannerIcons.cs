using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDA6E1BB1C26B5916, NameHash = 0x392CEA8FE98D0F4)]
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
        [NMS(Size = 0x42, EnumType = typeof(GcScannerIconTypes.ScanIconTypeEnum))]
        /* 0x0939C */ public GcScannerIcon[] ScannableIcons;
        [NMS(Size = 0x42, EnumType = typeof(GcScannerIconTypes.ScanIconTypeEnum))]
        /* 0x0D8B4 */ public GcScannerIcon[] ScannableIconsBinocs;
        [NMS(Size = 0x42, EnumType = typeof(GcScannerIconTypes.ScanIconTypeEnum))]
        /* 0x11DD0 */ public Colour[] ScannableColours;
        /* 0x121F0 */ public Colour BuildingColour;
        /* 0x12200 */ public Colour GenericColour;
        /* 0x12210 */ public Colour RelicColour;
        /* 0x12220 */ public Colour SignalColour;
        /* 0x12230 */ public Colour UnknownColour;
        /* 0x12240 */ public GcScannerIcon CreatureDiscovered;
        /* 0x1234C */ public GcScannerIcon CreatureUndiscovered;
        /* 0x12458 */ public GcScannerIcon CreatureUnknown;
        /* 0x12564 */ public GcScannerIcon MessageBeacon;
        /* 0x12670 */ public GcScannerIcon MessageBeaconSmall;
        /* 0x1277C */ public GcScannerIcon BaseBuildingMarker;
        /* 0x12888 */ public GcScannerIcon PlanetPoleNorth;
        /* 0x12994 */ public GcScannerIcon PlanetPoleSouth;
        /* 0x12AA0 */ public GcScannerIcon MonumentMarker;
        /* 0x12BAC */ public GcScannerIcon NetworkPlayerMarker;
        /* 0x12CB8 */ public GcScannerIcon NetworkPlayerMarkerShip;
        /* 0x12DC4 */ public GcScannerIcon NetworkPlayerMarkerVehicle;
        [NMS(Size = 0x4)]
        /* 0x12ED0 */ public GcScannerIcon[] NetworkFSPlayerMarkers;
        [NMS(Size = 0x4)]
        /* 0x13300 */ public GcScannerIcon[] NetworkFSPlayerMarkersShip;
        [NMS(Size = 0x4)]
        /* 0x13730 */ public Colour[] NetworkFSPlayerColours;
        [NMS(Size = 0x4)]
        /* 0x13770 */ public GcScannerIcon[] NetworkPlayerFreighter;
        /* 0x13BA0 */ public GcScannerIcon PortalMarker;
        /* 0x13CAC */ public GcScannerIcon BlackHole;
        /* 0x13DB8 */ public GcScannerIcon CreatureCurious;
        /* 0x13EC4 */ public GcScannerIcon CreatureAction;
        /* 0x13FD0 */ public GcScannerIcon CreatureTame;
        /* 0x140DC */ public GcScannerIcon CreatureDanger;
        /* 0x141E8 */ public GcScannerIcon CreatureFiend;
        /* 0x142F4 */ public GcScannerIcon CreatureMilk;
        [NMS(Size = 0x5, EnumType = typeof(GcScannerIconHighlightTypes.ScannerIconHighlightTypeEnum))]
        /* 0x14400 */ public TkTextureResource[] HighlightIcons;
        /* 0x14694 */ public GcScannerIcon MissionEnterOrbit;
        /* 0x147A0 */ public GcScannerIcon MissionEnterBuilding;
        /* 0x148AC */ public GcScannerIcon MissionEnterStation;
        /* 0x149B8 */ public GcScannerIcon MissionEnterFreighter;
        /* 0x14AC4 */ public GcScannerIcon MissionAbandonedFreighter;
        /* 0x14BD0 */ public GcScannerIcon CreatureInteraction;
        /* 0x14CDC */ public GcScannerIcon PetInteraction;
        /* 0x14DE8 */ public GcScannerIcon Pet;
        /* 0x14EF4 */ public GcScannerIcon PetSad;
        /* 0x15000 */ public GcScannerIcon PetActivity;
        /* 0x1510C */ public GcScannerIcon PlayerSettlement;
        /* 0x15218 */ public GcScannerIcon OtherPlayerSettlement;
        /* 0x15324 */ public GcScannerIcon FriendlyDrone;
        /* 0x15430 */ public GcScannerIcon PirateRaid;
    }
}
