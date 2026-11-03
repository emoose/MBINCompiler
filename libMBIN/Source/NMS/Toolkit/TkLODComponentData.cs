using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x7F48319674DF9287, NameHash = 0x542A1320)]
    public class TkLODComponentData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public List<TkLODModelResource> LODModels;
        [NMS(Index = 2)]
        /* 0x10 */ public float CrossFadeOverlap;
        [NMS(Index = 1)]
        /* 0x14 */ public float CrossFadeTime;
        [NMS(Index = 3)]
        /* 0x18 */ public bool UseMasterModel;
    }
}
