using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x933E6844872C884, NameHash = 0x5035CC19B55D3442)]
    public class GcSelectableObjectList : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Name;
        /* 0x10 */ public GcAlienRace Race;
        /* 0x18 */ public List<GcSelectableObjectData> Options;
    }
}
