using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
    public class GcAlienPuzzleMissionOverride : NMSTemplate       // size: 0x30
    {
        [NMS(Size = 0x10)]
        /* 0x00 */ public string Mission;
        [NMS(Size = 0x20)]
        /* 0x10 */ public string Puzzle;
    }
}
