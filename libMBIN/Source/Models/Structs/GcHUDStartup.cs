using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    public class GcHUDStartup : NMSTemplate     // size: 0x8
    {
        /* 0x00 */ public GcAudioWwiseEvents Audio;
        /* 0x04 */ public float Time;
    }
}
