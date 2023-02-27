using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3195411FB3EE778B, NameHash = 0xD2873CCA9A0EDD77)]
    public class GcPlayerControlInput : NMSTemplate
    {
        /* 0x00 */ public bool InterceptAllInputs;
        /* 0x08 */ public List<GcInputActions> InterceptInputWhitelist;
        /* 0x18 */ public List<GcInputActions> InterceptInputBlackList;
        /* 0x28 */ public List<NMSTemplate> Inputs;
    }
}
