using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xDA32F8C169DC5FFE, NameHash = 0xA8D08B04A442318C)]
    public class TkGeometryStreamData : NMSTemplate
    {
        /* 0x0 */ public List<TkMeshData> StreamDataArray;
    }
}
