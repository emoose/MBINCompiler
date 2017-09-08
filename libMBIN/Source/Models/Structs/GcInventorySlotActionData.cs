namespace MBINCompiler.Models.Structs
{
    public class GcInventorySlotActionData : NMSTemplate     // possibly in global?
    {
        /* 0x00 */ public bool Loops;
        /* 0x04 */ public float Time;
        /* 0x08 */ public float ScaleAtMin;
        /* 0x0C */ public float SclaeAtMax;
        /* 0x10 */ public TkCurveType AnimCurve;
        /* 0x14 */ public GcAudioWwiseEvents SuitAudio;
        /* 0x18 */ public GcAudioWwiseEvents ActionAudio;
    }
}
