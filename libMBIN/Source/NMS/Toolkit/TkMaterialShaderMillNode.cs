using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x8201DE134780E988, NameHash = 0xDBD75F4C)]
    public class TkMaterialShaderMillNode : NMSTemplate
    {
        [NMS(Index = 7)]
        /* 0x000 */ public Colour ColourValue;
        [NMS(Index = 8)]
        /* 0x010 */ public List<TkMaterialShaderMillConnect> Inputs;
        [NMS(Index = 9)]
        /* 0x020 */ public List<TkMaterialShaderMillConnect> Outputs;
        [NMS(Index = 5)]
        /* 0x030 */ public float FValue;
        [NMS(Index = 6)]
        /* 0x034 */ public float FValue2;
        [NMS(Index = 0)]
        /* 0x038 */ public int Id;
        [NMS(Index = 3)]
        /* 0x03C */ public int IValue;
        [NMS(Index = 4)]
        /* 0x040 */ public int IValue2;
        [NMS(Index = 10)]
        /* 0x044 */ public int WindowX;
        [NMS(Index = 11)]
        /* 0x048 */ public int WindowY;
        [NMS(Index = 2)]
        /* 0x04C */ public NMSString0x80 Value;
        [NMS(Index = 13)]
        /* 0x0CC */ public NMSString0x40 ParameterName;
        [NMS(Index = 1)]
        /* 0x10C */ public NMSString0x20 Type;
        [NMS(Index = 12)]
        /* 0x12C */ public bool ExposeAsParameter;
    }
}
