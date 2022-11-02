using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xC44DA4B5636F0C97, NameHash = 0x5FB32B8921A7FE69)]
    public class TkLSystemLocatorEntry : NMSTemplate
    {
        /* 0x00 */ public NMSString0x80 Model;
        /* 0x80 */ public float Probability;
        /* 0x88 */ public List<TkLSystemRestrictionData> Restrictions;
    }
}
