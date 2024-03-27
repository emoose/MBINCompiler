namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x946DADD6FB678EAA, NameHash = 0x863E7456C3844AC)]
    public class TkNoiseSuperPrimitiveData : NMSTemplate
    {
        /* 0x00 */ public float Width;
        /* 0x04 */ public float Height;
        /* 0x08 */ public float Depth;
        /* 0x0C */ public float Thickness;
        /* 0x10 */ public float CornerRadiusXY;
        /* 0x14 */ public float CornerRadiusZ;
        /* 0x18 */ public float BottomRadiusOffset;
    }
}
