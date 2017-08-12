using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
    public class TkAnimationComponentData : NMSTemplate     // size: 0xF0
    {
        /* 0x00 */ public TkAnimationData Idle;
        /* 0xE0 */ public List<TkAnimationData> Anims;
    }
}
