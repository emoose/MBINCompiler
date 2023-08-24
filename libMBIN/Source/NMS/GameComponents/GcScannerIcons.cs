using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x398D1617F840E14D, NameHash = 0x392CEA8FE98D0F4)]
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
        [NMS(Size = 0x40, EnumType = typeof(GcScannerIconTypes.ScanIconTypeEnum))]
        /* 0x0939C */ public GcScannerIcon[] ScannableIcons;
        [NMS(Size = 0x40, EnumType = typeof(GcScannerIconTypes.ScanIconTypeEnum))]
        /* 0x0D69C */ public GcScannerIcon[] ScannableIconsBinocs;
        [NMS(Size = 0x40, EnumType = typeof(GcScannerIconTypes.ScanIconTypeEnum))]
        /* 0x119A0 */ public Colour[] ScannableColours;
        /* 0x11DA0 */ public Colour BuildingColour;
        /* 0x11DB0 */ public Colour GenericColour;
        /* 0x11DC0 */ public Colour RelicColour;
        /* 0x11DD0 */ public Colour SignalColour;
        /* 0x11DE0 */ public Colour UnknownColour;
        /* 0x11DF0 */ public GcScannerIcon CreatureDiscovered;
        /* 0x11EFC */ public GcScannerIcon CreatureUndiscovered;
        /* 0x12008 */ public GcScannerIcon CreatureUnknown;
        /* 0x12114 */ public GcScannerIcon MessageBeacon;
        /* 0x12220 */ public GcScannerIcon MessageBeaconSmall;
        /* 0x1232C */ public GcScannerIcon BaseBuildingMarker;
        /* 0x12438 */ public GcScannerIcon PlanetPoleNorth;
        /* 0x12544 */ public GcScannerIcon PlanetPoleSouth;
        /* 0x12650 */ public GcScannerIcon MonumentMarker;
        /* 0x1275C */ public GcScannerIcon NetworkPlayerMarker;
        /* 0x12868 */ public GcScannerIcon NetworkPlayerMarkerShip;
        /* 0x12974 */ public GcScannerIcon NetworkPlayerMarkerVehicle;
        [NMS(Size = 0x4)]
        /* 0x12A80 */ public GcScannerIcon[] NetworkFSPlayerMarkers;
        [NMS(Size = 0x4)]
        /* 0x12EB0 */ public GcScannerIcon[] NetworkFSPlayerMarkersShip;
        [NMS(Size = 0x4)]
        /* 0x132E0 */ public Colour[] NetworkFSPlayerColours;
        [NMS(Size = 0x4)]
        /* 0x13320 */ public GcScannerIcon[] NetworkPlayerFreighter;
        /* 0x13750 */ public GcScannerIcon PortalMarker;
        /* 0x1385C */ public GcScannerIcon BlackHole;
        /* 0x13968 */ public GcScannerIcon CreatureCurious;
        /* 0x13A74 */ public GcScannerIcon CreatureAction;
        /* 0x13B80 */ public GcScannerIcon CreatureTame;
        /* 0x13C8C */ public GcScannerIcon CreatureDanger;
        /* 0x13D98 */ public GcScannerIcon CreatureFiend;
        /* 0x13EA4 */ public GcScannerIcon CreatureMilk;
        [NMS(Size = 0x5, EnumType = typeof(GcScannerIconHighlightTypes.ScannerIconHighlightTypeEnum))]
        /* 0x13FB0 */ public TkTextureResource[] HighlightIcons;
        /* 0x14244 */ public GcScannerIcon MissionEnterOrbit;
        /* 0x14350 */ public GcScannerIcon MissionEnterBuilding;
        /* 0x1445C */ public GcScannerIcon MissionEnterStation;
        /* 0x14568 */ public GcScannerIcon MissionEnterFreighter;
        /* 0x14674 */ public GcScannerIcon MissionAbandonedFreighter;
        /* 0x14780 */ public GcScannerIcon CreatureInteraction;
        /* 0x1488C */ public GcScannerIcon PetInteraction;
        /* 0x14998 */ public GcScannerIcon Pet;
        /* 0x14AA4 */ public GcScannerIcon PetSad;
        /* 0x14BB0 */ public GcScannerIcon PetActivity;
        /* 0x14CBC */ public GcScannerIcon PlayerSettlement;
        /* 0x14DC8 */ public GcScannerIcon OtherPlayerSettlement;
        /* 0x14ED4 */ public GcScannerIcon FriendlyDrone;
        /* 0x14FE0 */ public GcScannerIcon PirateRaid;
        /* 0x150EC */ public GcScannerIcon FuelAsteroid;
    }
}
