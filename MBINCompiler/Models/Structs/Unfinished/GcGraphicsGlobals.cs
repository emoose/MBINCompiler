using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBINCompiler.Models.Structs
{
    // loaded at 0x141624650+0x50
    public class GcGraphicsGlobals_Sub1 : NMSTemplate // 0x190 bytes
    {
        public float Unknown00;
        public float Unknown04;
        public float Unknown08;
        public float Unknown0C;

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
        public float Unknown5C;

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
        public float UnknownFC;

        public float Unknown100;
        public float Unknown104;
        public float Unknown108;
        public float Unknown10C;

        public float Unknown110;
        public float Unknown114;
        public float Unknown118;
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
        public float Unknown14C;

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

        [NMS(Size = 8, Ignore = true)]
        public byte[] Padding188;
    }

    // loaded at 0x141624650+0x490+0x90 & 0x141624650+0x640+0x90
    public class GcGraphicsGlobals_Sub2_Sub1 : NMSTemplate
    {
        [NMS(Size = 0x80)]
        public string Unknown0;

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
        public float UnknownFC;

        public float Unknown100;
        public float Unknown104;
        public float Unknown108;
        public float Unknown10C;

        public float Unknown110;
        public float Unknown114;
        public float Unknown118;
        public float Unknown11C;
    }

    // loaded at 0x141624650+0x490 & 0x141624650+0x640
    public class GcGraphicsGlobals_Sub2 : NMSTemplate // 0x1B0 bytes
    {
        public float Unknown0;
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
        public float Unknown5C;

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

        public GcGraphicsGlobals_Sub2_Sub1 Unknown90;
    }

    // loaded at 0x141624650
    public class GcGraphicsGlobals : NMSTemplate
    {
        public float Unknown0;
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

        public bool Unknown40; // unused?
        public bool Unknown41; // used
        public float Unknown44;
        public float Unknown48;
        public float Unknown4C;

        public GcGraphicsGlobals_Sub1 Unknown50;

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
        public float Unknown22C;

        public float Unknown230;
        public int Unknown234; // unused?
        public float Unknown238;
        public float Unknown23C;

        public float Unknown240;
        public float Unknown244;
        public float Unknown248;
        public float Unknown24C;

        public float Unknown250;
        public float Unknown254;
        public float Unknown258;
        public float Unknown25C;

        public float Unknown260;
        public float Unknown264;
        public float Unknown268;
        public float Unknown26C;

        public float Unknown270;
        public float Unknown274;
        public float Unknown278;
        public float Unknown27C;

        public float Unknown280;
        public float Unknown284;
        public float Unknown288;
        public float Unknown28C;

        public float Unknown290;
        public float Unknown294;
        public float Unknown298;
        public float Unknown29C;

        public float Unknown2A0;
        public float Unknown2A4;
        public float Unknown2A8;
        public float Unknown2AC;

        public float Unknown2B0;
        public float Unknown2B4;
        public float Unknown2B8;
        public float Unknown2BC;

        public bool Unknown2C0; // unused?
        public float Unknown2C4;
        public float Unknown2C8;
        public float Unknown2CC;

        public float Unknown2D0;
        public float Unknown2D4;
        public float Unknown2D8;
        public float Unknown2DC;

        public float Unknown2E0;
        public float Unknown2E4;
        public float Unknown2E8;
        public float Unknown2EC;

        public float Unknown2F0;
        public float Unknown2F4;
        public float Unknown2F8;
        public float Unknown2FC;

        public float Unknown300;
        public float Unknown304;
        public float Unknown308;
        public float Unknown30C;

        public float Unknown310;
        public float Unknown314;
        public float Unknown318;
        public float Unknown31C;

        public float Unknown320;
        public float Unknown324;
        public float Unknown328;
        public float Unknown32C;

        public float Unknown330;
        public float Unknown334;
        public float Unknown338;
        public float Unknown33C;

        public float Unknown340;
        public float Unknown344;
        public float Unknown348;
        public float Unknown34C;

        public float Unknown350;
        public float Unknown354;
        public float Unknown358;
        public float Unknown35C;

        public float Unknown360;
        public bool Unknown364; // unused?
        public bool Unknown365; // used
        public float Unknown368;
        public float Unknown36C;

        public float Unknown370;
        public float Unknown374;
        public float Unknown378;
        public float Unknown37C;

        public float Unknown380;
        public float Unknown384;
        public float Unknown388;
        public float Unknown38C;

        public float Unknown390;
        public float Unknown394;
        public float Unknown398;
        public float Unknown39C;

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
        public float Unknown3F4;
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

        public float Unknown420;
        public float Unknown424;
        public float Unknown428;
        public float Unknown42C;

        public float Unknown430;
        public float Unknown434;
        public float Unknown438;
        public float Unknown43C;

        public float Unknown440;
        public float Unknown444;
        public float Unknown448;
        public float Unknown44C;

        public float Unknown450;
        public float Unknown454;
        public float Unknown458;
        public float Unknown45C;

        public float Unknown460;
        public float Unknown464;
        public float Unknown468;
        public float Unknown46C;

        public float Unknown470;
        public float Unknown474;
        public float Unknown478;
        public float Unknown47C;

        public float Unknown480;
        public float Unknown484;
        public float Unknown488;
        public float Unknown48C;

        public GcGraphicsGlobals_Sub2 Unknown490;

        public GcGraphicsGlobals_Sub2 Unknown640;

        public float Unknown7F0;
        public float Unknown7F4;
        public float Unknown7F8;
        public float Unknown7FC;

        public bool Unknown800;

        [NMS(Size = 4)]
        public int[] Unknown804;

        public int Unknown814;

        [NMS(Size = 8, Ignore = true)]
        public byte[] Padding818;
    }
}
