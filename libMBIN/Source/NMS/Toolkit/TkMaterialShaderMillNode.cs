using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x19A0E8A7B2BEAC, NameHash = 0x465D81033D79E7BB)]
    public class TkMaterialShaderMillNode : NMSTemplate
    {
        /* 0x00 */ public int Id;
        /* 0x04 */ public NMSString0x20 Type;
        /* 0x24 */ public NMSString0x20 Value;
        /* 0x44 */ public int IValue;
        /* 0x48 */ public int IValue2;
        /* 0x4C */ public float FValue;
        /* 0x50 */ public float FValue2;
        /* 0x58 */ public List<TkMaterialShaderMillConnect> Inputs;
        /* 0x68 */ public List<TkMaterialShaderMillConnect> Outputs;
        /* 0x78 */ public int WindowX;
        /* 0x7C */ public int WindowY;
    }
}
