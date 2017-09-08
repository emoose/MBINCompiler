namespace MBINCompiler.Models.Structs
{
    public class GcGalaxyGlobals : NMSTemplate
    {
        /* 0X0 */ public float Unknown;
        /* 0X4 */ public float Unknown4;
        /* 0X8 */ public float Unknown8;
        /* 0XC */ public float UnknownC;
        /* 0X10 */ public float Unknown10;
        /* 0X14 */ public float Unknown14;
        /* 0X18 */ public float Unknown18;      // possibly NextStarSelectionLineThickness?
        /* 0X1C */ public float Unknown1C;
        /* 0X20 */ public float Unknown20;
        /* 0X24 */ public float Unknown24;
        /* 0X28 */ public float Unknown28;
        /* 0X2C */ public float Unknown2C;
        /* 0X30 */ public float Unknown30;
        /* 0X34 */ public float TopBottomBarVisibility;
        /* 0X38 */ public float PathSelectionPositionX;
        /* 0X3C */ public float PathSelectionPositionY;
        /* 0X40 */ public float PathCircleSeparation;
        /* 0X44 */ public float PathCircleForegroundRadius;
        /* 0X48 */ public float PathCircleBackgroundRadius;
        /* 0X4C */ public float SelectedPathIndicatorRadius;
        /* 0X50 */ public float SelectedPathIndicatorThickness;
        /* 0X54 */ public float Unknown54;
        /* 0X58 */ public float Unknown58;
        /* 0X5C */ public float Unknown5C;
        /* 0X60 */ public float Unknown60;
        /* 0X64 */ public float Unknown64;
        /* 0X68 */ public float Unknown68;
        /* 0X6C */ public float Unknown6C;
        /* 0X70 */ public float Unknown70;
        /* 0X74 */ public float Unknown74;
        /* 0X78 */ public float Unknown78;
        /* 0X7C */ public int UnknownInt7C;
        /* 0X80 */ public int UnknownInt80;
        /* 0X84 */ public float Unknown84;
        /* 0X88 */ public float Unknown88;
        /* 0X8C */ public float Unknown8C;
        [NMS(Size = 0x5, EnumValue = new[] { "Core", "FreeRoam", "Waypoint", "Blackhole", "Atlas" })]
        /* 0x90 */ public Colour[] PathIconColours;
        /* 0XE0 */ public Colour UnknownE0;
        /* 0XF0 */ public Colour UnknownF0;
        /* 0X100 */ public Colour Unknown100;
        /* 0X110 */ public Colour Unknown110;
        /* 0X120 */ public Colour Unknown120;       // possibly another GcGalaxyStarColours. Probably this one because alignment makes sense...
        /* 0X130 */ public Colour Unknown130;       // somewhere here?
        /* 0X140 */ public Colour Unknown140;
        /* 0X150 */ public Colour Unknown150;
        /* 0X160 */ public Colour Unknown160;
        /* 0X170 */ public Colour Unknown170;
        /* 0X180 */ public Colour Unknown180;
        /* 0X190 */ public Colour Unknown190;
        /* 0X1A0 */ public Colour Unknown1A0;
        /* 0X1B0 */ public Colour Unknown1B0;
        /* 0X1C0 */ public Colour Unknown1C0;
        /* 0X1D0 */ public Colour Unknown1D0;
        /* 0X1E0 */ public Colour Unknown1E0;
        /* 0X1F0 */ public Colour Unknown1F0;
        [NMS(Size = 0xA, EnumValue = new[] { "StartingLocation", "Home", "Waypoint", "Contact",
                           "Blackhole", "AtlasStation", "Selection", "PlanetBase",
                           "Visited", "ScanEvent"})]
        /* 0x200 */ public GcGalaxyMarkerSettings[] GalaxyMarkers;
        /* 0XD40 */ public float UnknownD40;
        /* 0XD44 */ public float UnknownD44;
        /* 0XD48 */ public float UnknownD48;
        /* 0XD4C */ public float UnknownD4C;
        /* 0XD50 */ public float UnknownD50;
        /* 0XD54 */ public float UnknownD54;
        /* 0XD58 */ public float UnknownD58;
        /* 0XD5C */ public float UnknownD5C;
        /* 0XD60 */ public float UnknownD60;
        /* 0XD64 */ public float UnknownD64;
        /* 0XD68 */ public float UnknownD68;
        /* 0XD6C */ public float UnknownD6C;
        /* 0XD70 */ public float UnknownD70;
        /* 0XD74 */ public float UnknownD74;
        /* 0XD78 */ public float UnknownD78;
        /* 0XD7C */ public float UnknownD7C;
        /* 0XD80 */ public float UnknownD80;
        /* 0XD84 */ public float UnknownD84;
        /* 0XD88 */ public float UnknownD88;
        /* 0XD8C */ public float UnknownD8C;
        /* 0XD90 */ public float UnknownD90;
        /* 0XD94 */ public float UnknownD94;
        /* 0XD98 */ public float UnknownD98;
        /* 0XD9C */ public float UnknownD9C;
        /* 0XDA0 */ public float UnknownDA0;
        /* 0XDA4 */ public float UnknownDA4;
        /* 0XDA8 */ public float UnknownDA8;
        /* 0XDAC */ public float UnknownDAC;
        /* 0XDB0 */ public float UnknownDB0;
        /* 0XDB4 */ public float UnknownDB4;
        /* 0XDB8 */ public float UnknownDB8;
        /* 0XDBC */ public int UnknownIntDBC;
        /* 0XDC0 */ public int UnknownIntDC0;
        /* 0XDC4 */ public float UnknownDC4;
        /* 0XDC8 */ public float UnknownDC8;
        /* 0XDCC */ public float UnknownDCC;
        /* 0XDD0 */ public GcGalaxyRenderAnostreakData AnoStreakConfig1;
        /* 0XE00 */ public GcGalaxyRenderAnostreakData AnoStreakConfig2;
        /* 0XE30 */ public float UnknownE30;
        /* 0XE34 */ public float UnknownE34;
        /* 0XE38 */ public float UnknownE38;
        /* 0XE3C */ public float UnknownE3C;
        /* 0XE40 */ public float UnknownE40;
        /* 0XE44 */ public float UnknownE44;
        /* 0XE48 */ public float UnknownE48;
        /* 0XE4C */ public float UnknownE4C;
        /* 0XE50 */ public float UnknownE50;
        /* 0XE54 */ public float UnknownE54;
        /* 0XE58 */ public float UnknownE58;
        /* 0XE5C */ public float UnknownE5C;
        /* 0XE60 */ public GcGalaxyStarColours UnknownE60;
        /* 0xEA0 */ public GcGalaxyCameraData GalaxyCameraData;
        /* 0xF04 */ public GcGalaxyAudioSetupData GalaxyAudioSetupData;
        /* 0xF48 */ public float ShipToGalaxyAnimationLength;
        /* 0xF4C */ public float ShipToGalaxyFadeOutLength;
        /* 0xF50 */ public float GalaxyToShipFadeInLength;
        /* 0xF54 */ public float GalaxyToShipFadeOutLength;
        /* 0xF58 */ public float ColourNoiseFrequency;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0xF5C */ public byte[] PaddingF5C;
        /* 0xF60 */ public GcGalaxyRenderSetupData UnknownF60;
        /* 0x1170 */ public GcGalaxyGenerationSetupData Unknown1160;
        /* 0x12E0 */ public GcGalaxyRenderSetupData Unknown12D0;
        /* 0x14F0 */ public GcGalaxyGenerationSetupData Unknown14D0;

        /* 0X1660 */ public GcGalaxySolarSystemParams GalaxySolarSystemParams;
        [NMS(Size = 0x8, Ignore = true)]
        public byte[] EndPadding;
    }
}
