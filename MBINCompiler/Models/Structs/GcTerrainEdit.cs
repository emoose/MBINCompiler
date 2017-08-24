using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
    public class GcTerrainEdit : NMSTemplate      // size: 0x8
    {
        public int Data;        // not actually an int.... not sure what... in the test file it has it as 'TestByte'...
        public int Position;
    }
}
