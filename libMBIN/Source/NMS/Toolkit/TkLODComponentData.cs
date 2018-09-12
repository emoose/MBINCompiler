using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0x18, GUID = 0x3F840374AD3BDE3C)]
    public class TkLODComponentData : NMSTemplate
    {
        /* 0x10 */ public List<TkLODModelResource> LODModel;
        /* 0x10 */ public float CrossFadeTime;
        /* 0x14 */ public float CrossFadeOverlap;
    }
}
