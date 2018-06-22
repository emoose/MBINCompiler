namespace libMBIN.Models.Structs
{
    public class GcTerrainGlobals : NMSTemplate
    {
        /* 0X0 */ public float Unknown;
        /* 0X4 */ public float Unknown4;
        /* 0X8 */ public float Unknown8;
        /* 0XC */ public float UnknownC;
        /* 0X10 */ public float Unknown10;
        /* 0X14 */ public float Unknown14;
        /* 0X18 */ public float Unknown18;
        /* 0X1C */ public float Unknown1C;
        /* 0X20 */ public float Unknown20;
        /* 0X24 */ public float Unknown24;
        /* 0X28 */ public float Unknown28;
        /* 0X2C */ public float Unknown2C;
        /* 0X30 */ public float Unknown30;

        // new offset: 0x34 for the following data I think...
        // there are some changes though...

        public float Unknown34; // planet gen related       
        public float Unknown38; // planet gen related
        public float Unknown3C; // planet gen related

        public float Unknown40; // unused?
        public float Unknown44; // unused?
        /* 0x48 */ public bool RemovePlanetTerrain;     // only checked on system warp
        [NMS(Size = 0x1, Ignore = true)]
        public byte[] Padding49;
        public bool Unknown4A;                          // only checked on system warp      // totally changes the terrain


        public int UnknownInt4C;
        public int UnknownInt50;
        public int UnknownInt54;

        public float Unknown58;
        public float Unknown5C;
        public float Unknown60;
        public float Unknown64;
        public float Unknown68;
        public float Unknown6C;
        public float Unknown70;

        public GcMiningSubstanceData Unknown74;
        public GcMiningSubstanceData Unknown80;
        public GcMiningSubstanceData Unknown8C;
        public GcMiningSubstanceData Unknown98;

        // colour maybe?
        /* 0XA4 */ public float UnknownA4;
        /* 0XA8 */ public float UnknownA8;
        /* 0XAC */ public float UnknownAC;
        /* 0XB0 */ public float UnknownB0;

        /* 0XB4 */ public GcTerrainOverlayColours UnknownB4;
        /* 0XCC */ public GcTerrainOverlayColours UnknownCC;
        /* 0XE4 */ public GcTerrainOverlayColours UnknownE4;

        /* 0xFC */ public GcTerrainEditing UnknownFC;
    }
}
