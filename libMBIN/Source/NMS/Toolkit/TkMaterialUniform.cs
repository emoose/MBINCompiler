using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xD4B7DD6169DC478, NameHash = 0x8CB8B180BCADFD4B)]
    public class TkMaterialUniform : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20 Name;
        /* 0x20 */ public Vector4f Values;
        /* 0x30 */ public List<Vector4f> ExtendedValues;
    }
}
