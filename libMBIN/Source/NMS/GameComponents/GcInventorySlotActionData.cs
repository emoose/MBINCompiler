namespace libMBIN.Models.Structs
{
	[NMS(Size = 0xC, GUID = 0x1A1C28C775BDCE51)]
    public class GcInventorySlotActionData : NMSTemplate
    {
        /* 0x00 */ public bool Loops;                       // 0
        /* 0x01 */ public bool Glows;
        /* 0x02 */ public bool Scales;
        /* 0x04 */ public float Time;                       // 3F800000h
        /* 0x08 */ public float ScaleAtMin;                 // 3F800000h
        /* 0x0C */ public float SclaeAtMax;                 // 40000000h
        /* 0x10 */ public TkCurveType AnimCurve;
        /* 0x14 */ public GcAudioWwiseEvents SuitAudio;
        /* 0x18 */ public GcAudioWwiseEvents ActionAudio;
    }
}
