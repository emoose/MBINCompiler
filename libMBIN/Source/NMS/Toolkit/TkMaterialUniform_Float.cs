using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x3E86DFC833FEC2DA, NameHash = 0xA0F0D8C9)]
    public class TkMaterialUniform_Float : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public Vector4f Values;
        [NMS(Index = 2)]
        /* 0x10 */ public List<Vector4f> ExtendedValues;
        [NMS(Index = 0)]
        /* 0x20 */ public VariableSizeString Name;
    }
}
