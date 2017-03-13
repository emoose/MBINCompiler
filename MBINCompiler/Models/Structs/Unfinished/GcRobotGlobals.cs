namespace MBINCompiler.Models.Structs.Unfinished
{
    public class GcRobotGlobals : NMSTemplate
    {
        public float Unknown0;
        public bool Unknown4;
        public float Unknown8;
        public float UnknownC;

        public float Unknown10;
        public float Unknown14;
        public float Unknown18;
        public float Unknown1C;
        public float Unknown20;
        public float Unknown24;
        public float Unknown28;
        public float Unknown2C;

        public float Unknown30;
        public float Unknown34;
        public float Unknown38;
        public float Unknown3C;

        public float Unknown40;
        public float Unknown44;
        public float Unknown48;
        public int UnknownInt4C;
        public int UnknownInt50;
        public int UnknownInt54;
        public int UnknownInt58;
        public float Unknown5C;

        // below chunk was all Vector4f's for some reason before. Didn't really seem to fit...
        public float Unknown60;
        public float Unknown64;
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
        public float UnknownC4;
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

        public float UnknownF0;
        public float UnknownF4;
        public float UnknownF8;

        [NMS(Size = 4, Ignore = true)]
        public byte[] PaddingFC;

        /* 0x100 */ public GcRobotLaserData WalkerLaserData;
        /* 0x150 */ public GcRobotLaserData QuadLaserData;
        /* 0x1A0 */ public GcDroneData DroneData;
    }
}
