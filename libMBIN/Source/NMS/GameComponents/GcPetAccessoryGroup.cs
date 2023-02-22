using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF708AF671743EDF0, NameHash = 0x1ED57D0465F00894)]
    public class GcPetAccessoryGroup : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Id;
        /* 0x10 */ public List<GcPetAccessoryType> DisallowedAccessories;
    }
}
