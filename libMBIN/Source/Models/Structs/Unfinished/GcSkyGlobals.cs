namespace libMBIN.Models.Structs
{
    public class GcSkyGlobals : NMSTemplate
    {
        public GcPhotoModeAdjustData Unknown0;
        public GcPhotoModeAdjustData Unknown18;
        public GcPhotoModeAdjustData Unknown30;
        public int UnknownInt48;
        /* 0x04C */ public float SunOrbitPeriod;
        public bool Unknown50;
        public float Unknown54;
        public float Unknown58;
        public float Unknown5C;
        public float Unknown60;
        public float Unknown64;     // part of previous QWORD
        public float Unknown68;
        public float Unknown6C;
        public float Unknown70;
        public float Unknown74;
        public float Unknown78;
        public float Unknown7C;
        public float Unknown80;
        public float Unknown84;
        public float Unknown88;
        public float Unknown8C;
        public float Unknown90;
        public float Unknown94;
        public float Unknown98;
        public float Unknown9C;
        public float UnknownA0;
        public float UnknownA4;
        public float UnknownA8;
        public float UnknownAC;
        public float UnknownB0;
        public float UnknownB4;
        public float UnknownB8;
        public float UnknownBC;
        public float UnknownC0;
        public bool UnknownC4;
        public float UnknownC8;
        public float UnknownCC;
        public float UnknownD0;
        public float UnknownD4;
        public float UnknownD8;
        public float UnknownDC;
        public float UnknownE0;
        public float UnknownE4;
        public float UnknownE8;
        public float UnknownEC;

        public Colour UnknownF0;
        public Colour Unknown100;
        public Colour Unknown110;
        public Colour Unknown120;
        public Colour Unknown130;
        public Colour Unknown140;

        public float Unknown150;
        public float Unknown154;
        public float Unknown158;
        public float Unknown15C;
        public float Unknown160;
        public float Unknown164;
        public float Unknown168;
        public float Unknown16C;
        public float Unknown170;
        public float Unknown174;
        public float Unknown178;
        public float Unknown17C;
        public float Unknown180;
        public float Unknown184;
        public float Unknown188;
        public float Unknown18C;
        public float Unknown190;
        public float Unknown194;
        public float Unknown198;
        public float Unknown19C;
        public float Unknown1A0;
        public float Unknown1A4;
        public float Unknown1A8;
        public float Unknown1AC;
        public float Unknown1B0;        // possibly padding?
        public float Unknown1B4;
        public float Unknown1B8;
        public float Unknown1BC;
        public float Unknown1C0;
        public float Unknown1C4;
        public float Unknown1C8;
        public float Unknown1CC;
        public float Unknown1D0;
        public float Unknown1D4;
        public float Unknown1D8;
        public float Unknown1DC;
        public float Unknown1E0;
        public float Unknown1E4;
        public float Unknown1E8;
        public float Unknown1EC;
        public float Unknown1F0;
        public float Unknown1F4;
        public float Unknown1F8;
        public float Unknown1FC;
        public float Unknown200;
        public float Unknown204;
        public float Unknown208;
        public float Unknown20C;
        public float Unknown210;
        public float Unknown214;
        public float Unknown218;
        public float Unknown21C;
        public float Unknown220;
        public float Unknown224;
        public float Unknown228;

        public GcSkyProperties Unknown22C;

        [NMS(Size = 0x4, EnumValue = new[] {"ClearFog", "StormFog", "ExtremeWeatherFog", "InFlightFog" })]
        /* 0x25C */ public GcFogProperties[] PlanetFogProperties;
        public GcSpaceSkyProperties Unknown5D0;
        public GcSpaceSkyProperties Unknown660;
        public GcSpaceSkyColours Unknown6F0;
        public GcSpaceSkyColours Unknown7A0;
        public GcSpaceSkyColours Unknown850;
        public GcSpaceSkyColours Unknown900;

        public float Unknown9B0;
        public long Unknown9B4;

        public Colour Unknown9C0;
        public Colour Unknown9D0;
        public Colour Unknown9E0;
        public Colour Unknown9F0;
        public Colour UnknownA00;
        public Colour UnknownA10;
    }
}
