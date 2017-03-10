using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
    public class GcVehicleGlobals : NMSTemplate
    {
        public bool Unknown0;
        [NMS(Size = 0x3, Ignore = true)]
        public byte[] Padding1;
        public float Unknown4;
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
        public float Unknown4C;
        public float Unknown50;
        public float Unknown54;
        public float Unknown58;
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] Padding5C;
        public Vector2f Unknown60;
        public int Unknown68;
        public float Unknown6C;
        public Vector2f Unknown70;
        public Vector2f Unknown78;

        [NMS(Size = 0x10)]
        public string Unknown80;
        [NMS(Size = 0x10)]
        public string Unknown90;
        [NMS(Size = 0x10)]
        public string UnknownA0;
        [NMS(Size = 0x10)]
        public string UnknownB0;
        [NMS(Size = 0x10)]
        public string UnknownC0;

        public float UnknownD0;
        public float UnknownD4;
        public float UnknownD8;
        public float UnknownDC;
        public float UnknownE0;
        public int UnknownE4;
        public int UnknownE8;
        public float UnknownEC;
        public int UnknownF0;
        public int UnknownF4;
        public float UnknownF8;
        public float UnknownFC;
        public Vector2f Unknown100;
        public float Unknown108;
        public Vector2f Unknown10C;
        public float Unknown114;
        public bool Unknown118;
        [NMS(Size = 0x3, Ignore = true)]
        public byte[] Padding119;
        public float Unknown11C;
        public float Unknown120;
        public float Unknown124;
        public float Unknown128;
        public float Unknown12C;
        public float Unknown130;
        public float Unknown134;
        public float Unknown138;
        public float Unknown13C;
        public float Unknown140;
        public float Unknown144;
        public float Unknown148;
        public bool Unknown14C;
        [NMS(Size = 0x3, Ignore = true)]
        public byte[] Padding14D;
        public float Unknown150;
        public float Unknown154;
        public int Unknown158;
        public float Unknown15C;
        public float Unknown160;
        public bool Unknown164;
        [NMS(Size = 0x3, Ignore = true)]
        public byte[] Padding165;
        public Vector2f Unknown168;
        public float Unknown170;
        public float Unknown174;
        public bool Unknown178;
        [NMS(Size = 0x3, Ignore = true)]
        public byte[] Padding179;
        public float Unknown17C;

        //public List<float> Dead;

        public GcVehicleData BikeData;        // size: 0xBB0
        public GcVehicleData MedBuggyData;
        public GcVehicleData TruckData;

    }
}
