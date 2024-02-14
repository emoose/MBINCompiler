using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x76111D01272E80F, NameHash = 0x4B24756D3BA22E88)]
    public class GcHUDStartup : NMSTemplate
    {
        /* 0x0 */ public GcAudioWwiseEvents Audio;
        /* 0x4 */ public float Time;
        /* 0x8 */ public NMSString0x10 RequiresTechBroken;
    }
}
