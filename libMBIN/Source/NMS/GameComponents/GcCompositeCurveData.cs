using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8D8F5A903D11E13A, NameHash = 0x4CD8AD55)]
    public class GcCompositeCurveData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public List<GcCompositeCurveElementData> Elements;
        [NMS(Index = 0)]
        /* 0x10 */ public float StartValue;
    }
}
