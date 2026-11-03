using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x28310B8BBED83A6A, NameHash = 0xACB428DD)]
    public class TkMaterialUniform_UInt : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public Vector4i Values;
        [NMS(Index = 2)]
        /* 0x10 */ public List<Vector4i> ExtendedValues;
        [NMS(Index = 0)]
        /* 0x20 */ public VariableSizeString Name;
    }
}
