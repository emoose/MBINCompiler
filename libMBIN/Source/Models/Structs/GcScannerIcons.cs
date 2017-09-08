namespace libMBIN.Models.Structs
{
    public class GcScannerIcons : NMSTemplate       // size: 0x4A90
    {
        /* 0x0000 */ public TkTextureResource TaggedBuilding;
        /* 0x0084 */ public TkTextureResource Ship;
        /* 0x0108 */ public TkTextureResource Vehicle;
        /* 0x018C */ public TkTextureResource Freighter;
        /* 0x0210 */ public TkTextureResource FreighterBase;
        /* 0x0294 */ public TkTextureResource PlayerFreighter;
        /* 0x0318 */ public TkTextureResource PlayerBase;
        /* 0x039C */ public TkTextureResource Death;
        /* 0x0420 */ public TkTextureResource Bounty1;
        /* 0x04A4 */ public TkTextureResource Bounty2;
        /* 0x0528 */ public TkTextureResource Bounty3;
        /* 0x05AC */ public TkTextureResource Battle;
        /* 0x0630 */ public TkTextureResource ShipSmall;
        /* 0x06B4 */ public TkTextureResource DeathSmall;
        /* 0x0738 */ public TkTextureResource BountySmall;
        /* 0x07BC */ public TkTextureResource BattleSmall;
        /* 0x0840 */ public TkTextureResource TimedEvent;
        /* 0x08C4 */ public TkTextureResource Checkpoint;
        /* 0x0948 */ public TkTextureResource CircleAnimation;
        /* 0x09CC */ public TkTextureResource HexAnimation;
        /* 0x0A50 */ public TkTextureResource ArrowSmall;
        /* 0x0AD4 */ public TkTextureResource ArrowLarge;

        [NMS(Size = 5)]
        /* 0x0B58 */ public TkTextureResource[] GenericIcons;

        [NMS(Size = 0x11)]
        /* 0x0DEC */ public TkTextureResource[] BuildingIcons;

        [NMS(Size = 0x11)]
        /* 0x16B0 */ public TkTextureResource[] BuildingIconsLarge;

        [NMS(Size = 0x11)]
        /* 0x1F74 */ public TkTextureResource[] BuildingIconsInactive;

        [NMS(Size = 0x11)]
        /* 0x2838 */ public TkTextureResource[] BuildingIconsInactiveLarge;

        [NMS(Size = 0x11)]
        /* 0x30FC */ public TkTextureResource[] BuildingIconsHuge;

        [NMS(Size = 0x17)]
        /* 0x39C0 */ public TkTextureResource[] ScannableIcons;

        [NMS(Size = 0x4, Ignore = true)]
        /* 0x459C */ public byte[] Padding459C;

        [NMS(Size = 0x17)]
        /* 0x45A0 */ public Colour[] ScannableColours;

        /* 0x4710 */ public Colour BuildingColour;
        /* 0x4720 */ public Colour GenericColour;
        /* 0x4730 */ public Colour InactiveColour;
        /* 0x4740 */ public Colour RelicColour;
        /* 0x4750 */ public Colour SignalColour;
        /* 0x4760 */ public Colour UnknownColour;

        /* 0x4770 */ public TkTextureResource CreatureDiscovered;
        /* 0x47F4 */ public TkTextureResource CreatureUndiscovered;
        /* 0x4878 */ public TkTextureResource CreatureUnknown;
        /* 0x48FC */ public TkTextureResource MessageBeacon;
        /* 0x4980 */ public TkTextureResource MessageBeaconSmall;
        /* 0x4A04 */ public TkTextureResource BaseBuildingMarker;

        [NMS(Size = 8, Ignore = true)]
        /* 0x4A88 */ public byte[] EndPadding;
    }
}
