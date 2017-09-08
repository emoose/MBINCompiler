using System.Collections.Generic;

namespace libMBIN.Models.Structs
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
        public float VehicleSummonDistance;
        public float Unknown4C;
        public float Unknown50;
        public float Unknown54;
        public float Unknown58;
        public float Unknown5C;
        public Vector4f Unknown60;      // maybe??
        public Vector4f Unknown70;
        public Vector4f Unknown80;

        [NMS(Size = 0x10)]
        public string Unknown90;        // VEHICLE_ENGINE
        [NMS(Size = 0x10)]
        public string UnknownA0;        // VEHICLE_ENGINE
        [NMS(Size = 0x10)]
        public string UnknownB0;        // VEHICLE_BOOST
        [NMS(Size = 0x10)]
        public string UnknownC0;        // VEHICLE_ENGINE
        [NMS(Size = 0x10)]
        public string UnknownD0;        // VEHICLE_LASER

        public float UnknownE0;
        public float UnknownE4;
        public float UnknownE8;
        public float UnknownEC;
        public float UnknownF0;
        public int UnknownIntF4;
        public int UnknownIntF8;
        public float UnknownFC;
        public int UnknownInt100;
        public int UnknownInt104;
        public float Unknown108;
        public float Unknown10C;
        public float Unknown110;
        public float Unknown114;
        public float Unknown118;
        public float Unknown11C;
        public float Unknown120;
        public float Unknown124;
        public bool Unknown128;
        [NMS(Size = 0x3, Ignore = true)]
        public byte[] Padding129;
        public float Unknown12C;
        public float Unknown130;
        public float Unknown134;
        public float Unknown138;
        public float Unknown13C;
        public float Unknown140;
        public float Unknown144;
        public float Unknown148;
        public float Unknown14C;
        public float Unknown150;
        public float EngineFuelConsumeRate;
        public float Unknown158;
        public float Unknown15C;
        public float Unknown160;
        public float Unknown164;
        public bool Unknown168;
        public float Unknown16C;
        public float Unknown170;
        public int UnknowInt174;       // 2nd 4 bytes of previous QWORD
        public float Unknown178;
        public float Unknown17C;
        public bool Unknown180;
        public float Unknown184;
        public float Unknown188;
        public float Unknown18C;
        public float Unknown190;
        public bool Unknown194;
        /* 0x198 */ public float ScannerRechargeTime;

        [NMS(Size = 0x4, Ignore = true)]
        public byte[] Padding19C;

        public GcVehicleData BikeData;        // size: 0xBB0
        public GcVehicleData MedBuggyData;
        public GcVehicleData TruckData;

    }
}
