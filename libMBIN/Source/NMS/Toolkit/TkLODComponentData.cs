using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x79345DCE43DBC247, NameHash = 0x7F33053EA7D28399)]
    public class TkLODComponentData : NMSTemplate
    {
        /* 0x00 */ public List<TkLODModelResource> LODModels;
        /* 0x10 */ public float CrossFadeTime;
        /* 0x14 */ public float CrossFadeOverlap;
    }
}
