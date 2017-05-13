namespace MBINCompiler.Models.Structs
{
    public class GcGalaxyGlobals : NMSTemplate
    {
        public float Unknown0;
        public float Unknown4;
        public float Unknown8;              // something to do with the UI?
        public float UnknownC;              // somehting to do with the UI?
        public float Unknown10;
        public float Unknown14;
        public float Unknown18;
        public float Unknown1C;
        public float Unknown20;
        public float Unknown24;
        public float Unknown28;
        public float Unknown2C;
        public int Unknown30;
        public int Unknown34;
        [NMS(Size = 0x8, Ignore = true)]
        public byte[] Padding38;
        [NMS(Size = 0x5, EnumValue = new[] { "Core", "FreeRoam", "Waypoint", "Blackhole", "Atlas" })]
        public Colour[] PathIconColours;
        [NMS(Size = 0x7, EnumValue = new[] { "Home", "Waypoint", "Contact", "Blackhole", "AtlasStation", "Selection", "PlanetBase" })]
        public GcGalaxyMarkerSettings[] GalaxyMarkers;

        public float Unknown3A0;
        public float Unknown3A4;
        public float Unknown3A8;
        public float Unknown3AC;
        public float Unknown3B0;
        public float Unknown3B4;
        public float Unknown3B8;
        public float Unknown3BC;
        public float Unknown3C0;
        public float Unknown3C4;
        public float Unknown3C8;
        public float Unknown3CC;
        public float Unknown3D0;
        public float Unknown3D4;
        public float Unknown3D8;
        public float Unknown3DC;
        public float Unknown3E0;
        public float Unknown3E4;
        public float Unknown3E8;
        public float Unknown3EC;
        public float Unknown3F0;
        public int UnknownInt3F4;
        public float Unknown3F8;
        public float Unknown3FC;
        public float Unknown400;
        public float Unknown404;
        public float Unknown408;
        public float Unknown40C;
        public float Unknown410;
        public float Unknown414;
        public float Unknown418;
        public float Unknown41C;
        public int UnknownInt420;
        public int UnknownInt424;
        public float Unknown428;        // maybe padding with the next 4 bytes also?
        public float Unknown42C;
        /* 0x430 */
        public GcGalaxyRenderAnostreakData AnoStreakConfig1;
        /* 0x460 */
        public GcGalaxyRenderAnostreakData AnoStreakConfig2;

        public Colour Unknown490;
        public Colour Unknown4A0;
        public float Unknown4B0;
        [NMS(Size = 0xC, Ignore = true)]
        public byte[] Padding4B4;
        public Colour Unknown4C0;

        public float Unknown4D0;
        public float Unknown4D4;
        [NMS(Size = 0x8, Ignore = true)]
        public byte[] Padding4D8;

        /* 0x4E0 */ public GcGalaxyStarColours GalaxyStarColours1;
        /* 0x520 */ public GcGalaxyStarColours GalaxyStarColours2;
        /* 0X560 */ public GcGalaxyCameraData GalaxyCameraData;
        /* 0x5B8 */ public GcGalaxyAudioSetupData GalaxyAudioSetupData;
        public float Unknown5FC;
        public float Unknown600;
        public float Unknown604;
        public float Unknown608;
        public float Unknown60C;

        public GcGalaxyRenderSetupData Unknown610;
        public GcGalaxyGenerationSetupData Unknown800;
        public GcGalaxyRenderSetupData Unknown970;
        public GcGalaxyGenerationSetupData UnknownB60;
    }
}
