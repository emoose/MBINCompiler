using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x30)]
    public class GcAlienPuzzleMissionOverride : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x00 */ public string Mission;
        [NMS(Size = 0x20)]
        /* 0x10 */ public string Puzzle;
    }
}
