using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBINCompiler.Models.Structs
{
    public class GcSolarGenerationGlobals : NMSTemplate
    {
        public bool Unknown0;
        [NMS(Size = 0xF)]
        public byte[] Unknown1;

        public float Unknown10;
        public float Unknown14;
        public float Unknown18; // unused?
        public float Unknown1C; // unused?

        public float Unknown20;
        public float Unknown24;
        public bool Unknown28; // unused?
        public int Unknown2C; // unused? non-float?

        public bool Unknown30;
        public float Unknown34; // unused?
        public float Unknown38; // unused?
        public float Unknown3C; // qword?

        public float Unknown40; // unused?
        public float Unknown44;
        public float Unknown48;
        public float Unknown4C;

        public float Unknown50;
        public int Unknown54;
        public int Unknown58;
        public float Unknown5C;

        public int Unknown60;
        public int Unknown64;
        public float Unknown68;
        public float Unknown6C;

        public float Unknown70;
        public bool Unknown74;
        public float Unknown78;
        public float Unknown7C;

        public int Unknown80;
        public float Unknown84; // unused?
        public float Unknown88; // unused?
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
        public int UnknownC8;
        public int UnknownCC;

        [NMS(Size = 0x10)]
        public string UnknownD0; // unused?

        public float UnknownE0;
        public float UnknownE4;
        public float UnknownE8;
        public float UnknownEC;

        public int UnknownF0;
        public int UnknownF4;

        [NMS(Size = 0x10)]
        public string UnknownF8;

        public float Unknown108; // unused?
        public float Unknown10C; // unused?

        public float Unknown110;
        public float Unknown114;
        public float Unknown118;
        public float Unknown11C;

        public float Unknown120; // unused?
        public float Unknown124; // unused?
        public int Unknown128;
        public float Unknown12C;

        public float Unknown130;

        [NMS(Size = 6)]
        public Vector3i[] Unknown134;

        public int Unknown17C;
    }
}
