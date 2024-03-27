using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x817C66DB7D882C65, NameHash = 0x465D81033D79E7BB)]
    public class TkMaterialShaderMillNode : NMSTemplate
    {
        /* 0x00 */ public int Id;
        /* 0x04 */ public NMSString0x20 Type;
        /* 0x24 */ public NMSString0x80 Value;
        /* 0xA4 */ public int IValue;
        /* 0xA8 */ public int IValue2;
        /* 0xAC */ public float FValue;
        /* 0xB0 */ public float FValue2;
        /* 0xB8 */ public List<TkMaterialShaderMillConnect> Inputs;
        /* 0xC8 */ public List<TkMaterialShaderMillConnect> Outputs;
        /* 0xD8 */ public int WindowX;
        /* 0xDC */ public int WindowY;
    }
}
